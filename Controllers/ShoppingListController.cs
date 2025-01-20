using Microsoft.AspNetCore.Mvc;
using ShoppingList.Data;
using ShoppingList.Models;
using System.Linq;

namespace ShoppingList.Controllers
{
    public class ShoppingListController : Controller
    {
        private readonly ShoppingListContext _context;

        public ShoppingListController(ShoppingListContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var items = _context.GroceryItems.ToList();
            return View(items);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(GroceryItem item)
        {
            if (ModelState.IsValid)
            {
                _context.GroceryItems.Add(item);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(item);
        }

        public IActionResult Delete (int id)
        {
            var item = _context.GroceryItems.Find(id);
            if (item != null)
            {
                _context.GroceryItems.Remove(item);
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}
