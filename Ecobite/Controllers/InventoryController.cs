using Ecobite.Data;
using Ecobite.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Ecobite.Controllers
{
    public class InventoryController : Controller
    {
        private readonly ApplicationDbContext _db;
        public InventoryController(ApplicationDbContext db)
            
        {
            _db = db;
            
        }
        public IActionResult Index()
        {
            List<InventoryModel>objInventoryList= _db.Inventories
                .Include(i => i.FoodItem) 
                .ToList();
              

            return View(objInventoryList);
        }
    }
}
