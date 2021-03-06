﻿using System;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using CustomerWebApp.Models;
using CustomerWebApp.ViewModel;
using CustomerWebApp.Abstract;

namespace CustomerWebApp.Controllers
{
    public class CustomersController : Controller
    {
        private CustomerDBEntities _db;
        private ICustomerMapper _customerMapper;

        public CustomersController(CustomerDBEntities db, ICustomerMapper customerMapper)
        {
            _db = db;
            _customerMapper = customerMapper;
        }

        // GET: Customers
        public ActionResult Index(string searchString)
        {
            var customers = from c in _db.Customers
                         select c;

            if (!String.IsNullOrEmpty(searchString))
            {
                customers = customers.Where(
                                                s => s.CustomerID.ToString().Contains(searchString) ||
                                                     s.FirstName.Contains(searchString) ||
                                                     s.Lastname.Contains(searchString) ||
                                                     s.Address1.Contains(searchString) ||
                                                     s.Address2.Contains(searchString) ||
                                                     s.County.Contains(searchString) ||
                                                     s.Town.Contains(searchString) ||
                                                     s.Postcode.Contains(searchString) ||
                                                     s.EmailAddress.Contains(searchString)
                                           );
            }

            return View(customers.ToList());
        }

        // GET: Customers/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Customer customer = _db.Customers.Find(id);
            if (customer == null)
            {
                return HttpNotFound();
            }
            return View(customer);
        }

        // GET: Customers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Customers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CustomerID,FirstName,Lastname,Address1,Address2,Town,County,Postcode,Age,EmailAddress")] CustomerViewModel customer)
        {
            if (ModelState.IsValid)
            {
                Customer customerModel = _customerMapper.GetCustomer(customer);

                _db.Customers.Add(customerModel);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(customer);
        }

        // GET: Customers/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Customer customer = _db.Customers.Find(id);
            if (customer == null)
            {
                return HttpNotFound();
            }

            CustomerViewModel cvm = _customerMapper.GetCustomerViewModel(customer);
            return View(cvm);
        }

        // POST: Customers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CustomerID,FirstName,Lastname,Address1,Address2,Town,County,Postcode,Age,EmailAddress")] CustomerViewModel customer)
        {
            if (ModelState.IsValid)
            {
                Customer customerModel = _customerMapper.GetCustomer(customer);

                _db.Entry(customerModel).State = EntityState.Modified;
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(customer);
        }

        // GET: Customers/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Customer customer = _db.Customers.Find(id);
            if (customer == null)
            {
                return HttpNotFound();
            }
            return View(customer);
        }

        // POST: Customers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Customer customer = _db.Customers.Find(id);
            _db.Customers.Remove(customer);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
