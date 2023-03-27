using Microsoft.AspNetCore.Mvc;
using SmallTask.Models;

namespace SmallTask.Controllers
{
    public class EnterNameController : Controller
    {
        public IActionResult Index(User user)
        {
            return View(user);
        }
    }
}
