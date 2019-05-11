using System;
using System.Collections.Generic;
using System.Linq;
using TeisterMask.Data;
using TeisterMask.Models;
using Microsoft.AspNetCore.Mvc;

namespace TeisterMask.Controllers
{
    public class TaskController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            using(var db = new TeisterMaskDbContext())
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
        public IActionResult Create (string title, string status)
        {
            if (string.IsNullOrEmpty(title) || string.IsNullOrEmpty(status))
            {
                return RedirectToAction("Index");
            }

            var task = new Task
            {
                Title = title,
                Status = status
            };

            using (var db = new TeisterMaskDbContext())
            {
                db.Tasks.Add(task);
                db.SaveChanges();

                return RedirectToAction("Index");
            }
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            using (var db = new TeisterMaskDbContext())
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
            using (var db = new TeisterMaskDbContext())
            {
                var task = db.Tasks.FirstOrDefault(t => t.Id == someTask.Id);

                if (task == null)
                {
                    return RedirectToAction("Index");
                }

                task.Title = someTask.Title;
                task.Status = someTask.Status;

                db.SaveChanges();

                return RedirectToAction("Index");
            }
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            using(var db = new TeisterMaskDbContext())
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
        public IActionResult Delete(Task toDelete)
        {
            using (var db = new TeisterMaskDbContext())
            {
                var task = db.Tasks.FirstOrDefault(t => t.Id == toDelete.Id);

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