using CalculatorBMI.Models;
using Microsoft.AspNetCore.Mvc;

namespace CalculatorBMI.Controllers
{
    public class CalculatorController : Controller
    {
        public IActionResult Index()
        {
            // Ovde možeš dodati potrebne podatke ili logiku
            return View();
        }

        [HttpPost]
        public IActionResult CalculateBMI([FromBody] User user)
        {
            if (ModelState.IsValid)
            {
                if (user.Weight <= 0 || user.Height <= 0)
                {
                    return BadRequest("Težina i visina moraju biti pozitivni brojevi.");
                }

                // Implementiraj logiku za izračunavanje BMI
                user.BMI = (user.Weight / (user.Height * user.Height)) * 10000;

                // Sačuvaj korisnika u bazu (opciono, ako je potrebno)
                // _context.Users.Add(user);
                // _context.SaveChanges();

                return Ok(new { bmi = user.BMI });
            }
            else
            {
                return BadRequest(ModelState);
            }
        }
    }
}
