using Microsoft.AspNetCore.Mvc;
using test2.Models;

namespace test2.Controllers
{
    public class SymmetryController : Controller
    {
        
            public IActionResult Index()
            {
                return View(new SymmetryViewModel());
            }

            [HttpPost]
            public IActionResult CheckSymmetry(SymmetryViewModel model)
            {
                if (ModelState.IsValid)
                {
                    model.IsSymmetrical = IsSymmetrical(model.Number);
                }
                return View("Index", model);
            }

            private bool IsSymmetrical(int number)
            {
                string strNum = number.ToString();
                string reversed = new string(strNum.Reverse().ToArray());
                return strNum == reversed;
            }
        
    }
}
