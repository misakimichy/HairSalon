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
            // Show all the customers regardless the stylist
            List<Customer> model = _db.Customers.ToList();
            return View(model);
        }

        public ActionResult Create()
        {
            ViewBag.StylistId = new SelectList(_db.Stylists, "StylistId", "Name");
            return View();
        }

        [HttpPost]
        public ActionResult Create(Customer customer)
        {
            _db.Customers.Add(customer);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Details(int id)
        {
            Customer thisCustomer = _db.Customers.FirstOrDefault(customers => customers.CustomerId == id);
            Stylist thisStylist = _db.Stylists.FirstOrDefault(stylists => stylists.StylistId == thisCustomer.StylistId);
            ViewBag.Name = thisStylist.Name;
            ViewBag.Active = thisStylist.Active;
            return View(thisCustomer);
        }

        public ActionResult Edit(int id)
        {
            var thisCustomer = _db.Customers.FirstOrDefault(customers => customers.CustomerId == id);
            List<Stylist> activeStylist = _db.Stylists.Where(stylists => stylists.Active == true).ToList();
            ViewBag.activeStylist = activeStylist;
            return View(thisCustomer);
        }

        [HttpPost]
        public ActionResult Edit(Customer customer)
        {
            _db.Entry(customer).State = EntityState.Modified;
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}