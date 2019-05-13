using System;
using System.Collections.Generic;
using System.Linq;
using ToDoList.Data;
using ToDoList.Models;
using Microsoft.AspNetCore.Mvc;

namespace ToDoList.Controllers
{
    public class TaskController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
           using (var db = new ToDoDbContext())
            {
                var task = db.Tasks.ToList();

                return View(task);
            }
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(string title, string comments)
        {
            if (string.IsNullOrEmpty(title) || string.IsNullOrEmpty(comments))
            {
                return RedirectToAction("Index");
            }

            var task = new Task
            {
                Title = title,
                Comments = comments
            };

            using (var db = new ToDoDbContext())
            {
                db.Tasks.Add(task);
                db.SaveChanges();

                return RedirectToAction("Index");
            }
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            using (var db = new ToDoDbContext())
            {
                var task = db.Tasks.FirstOrDefault(t => t.Id == id);

                if (task == null)
                {
                    return RedirectToAction("Index");
                }

                return View(task);
            }
        }
        [HttpPost]
        public IActionResult Edit(Task someTask)
        {
            using(var db = new ToDoDbContext())
            {
                var task = db.Tasks.FirstOrDefault(t => t.Id == someTask.Id);

                if (task == null)
                {
                    return RedirectToAction("Index");
                }

                task.Title = someTask.Title;
                task.Comments = someTask.Comments;

                db.SaveChanges();

                return RedirectToAction("Index");
            }
        }
        [HttpGet]
        public IActionResult Details(int id)
        {
            using(var db = new ToDoDbContext())
            {
                var task = db.Tasks.FirstOrDefault(t => t.Id == id);

                if (task == null)
                {
                    return RedirectToAction("Index");
                }

                return View(task);
            }
        }
        [HttpPost]
        public IActionResult Delete (int id)
        {
            using (var db = new ToDoDbContext())
            {
                var task = db.Tasks.FirstOrDefault(t => t.Id == id);

                if (task == null)
                {
                    return RedirectToAction("Index");
                }

                db.Tasks.Remove(task);
                db.SaveChanges();

                return RedirectToAction("Index");
            }
        }
    }
}