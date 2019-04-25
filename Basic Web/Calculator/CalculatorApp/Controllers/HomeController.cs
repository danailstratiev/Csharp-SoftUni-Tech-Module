using CalculatorApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace CalculatorApp.Controllers
{
    public class HomeController : Controller
    {
       [HttpGet]
        public IActionResult Index (decimal leftOperand, decimal rightOperand, string @operator, decimal result)
        {
            
            Calculator calculator = new Calculator()
            {
                LeftOperand = leftOperand,
                RightOperand = rightOperand,
                Operator = @operator,
                Result = result
            };

            return View (calculator);
        }
        [HttpPost]
        public IActionResult Calculate(Calculator calculator)
        {
            calculator.CalculateResult();

            if (calculator.RightOperand == 0 && calculator.Operator == "/")
            {
                TempData["Error"] = "Can not divide by 0 !";
            }

            return RedirectToAction("Index", calculator);
        }
    }
}
