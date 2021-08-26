using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AppWithIdentity.Controllers
{
    [Authorize]
    public class ContactListController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
