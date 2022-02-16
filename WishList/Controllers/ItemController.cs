using Microsoft.AspNetCore.Mvc;
using WishList.Data;

namespace WishList.Controllers
{
    public class ItemController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ItemController(ApplicationDbContext applicationDbContext)
        {
            _context = applicationDbContext;
        }

        public IActionResult Index() {
            return View("Index");
        }

        public IActionResult Create()
        {
            return View();
        }
        
        public IActionResult Delete()
        {
            return View();
        }
    }
}
