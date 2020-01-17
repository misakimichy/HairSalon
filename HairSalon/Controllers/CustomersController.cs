using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;
using HairSalon.Models;

namespace HairSalon.Controllers
{
    public class CustomersController : Controller
    {
        private readonly HairSalonContext _db;
        public CustomersController(HairSalonContext db)
        {
            _db = db;
        }
        public ActionResult Index()
        {
            List<Customer> model = _db.Customers.Include(clients => clients.Stylist).ToList();
            return View(model);
        }
    }
}