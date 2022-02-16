using Microsoft.AspNetCore.Mvc;
using WishList.Data;
using WishList.Models;

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

        public IActionResult Create(Item item)
        {
            _context.Items.Add(item);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        
        public IActionResult Delete(int Id)
        {
            Item tmpItem  = _context.Items.Find(Id);
            _context.Items.Remove(tmpItem);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
