using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AppWithIdentity.Controllers
{
    [Authorize]
    public class ContactListController : Controller
    {
        [Authorize(Roles = "admin,operator")]
        public IActionResult Index()
        {
            return View();
        }

        [Authorize(Roles = "admin")]
        public IActionResult Edit()
        {
            return View();
        }

        [Authorize(Roles = "admin")]
        public IActionResult Delete()
        {
            return View();
        }
    }
}
