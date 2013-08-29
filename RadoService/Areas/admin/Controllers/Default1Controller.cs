using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RadoService.DAl;
using System.Data.Entity.Validation;
using System.Diagnostics;

namespace RadoService.Areas.admin.Controllers
{
    public class Default1Controller : BasicAdminController
    {
        private RadoServiseEntities db = new RadoServiseEntities();

        //
        // GET: /admin/Default1/

        public ActionResult Index()
        {
            return View(db.Client.ToList());
        }

        //
        // GET: /admin/Default1/Details/5

        public ActionResult Details(int id = 0)
        {
            Client client = db.Client.Find(id);
            if (client == null)
            {
                return HttpNotFound();
            }
            return View(client);
        }

        //
        // GET: /admin/Default1/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /admin/Default1/Create

        [HttpPost]
        public ActionResult Create(Client client)
        {
            if (ModelState.IsValid)
            {
                
                try
                {
                    // Your code...
                    // Could also be before try if you know the exception occurs in SaveChanges
                db.Client.Add(client);
                    db.SaveChanges();
                return RedirectToAction("Index");
                   
                }
                catch (DbEntityValidationException dbEx)
                {
                    foreach (var validationErrors in dbEx.EntityValidationErrors)
                    {
                        foreach (var validationError in validationErrors.ValidationErrors)
                        {
                            Trace.TraceInformation("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                        }
                    }
                }
                
            }

            return View(client);
        }

        //
        // GET: /admin/Default1/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Client client = db.Client.Find(id);
            if (client == null)
            {
                return HttpNotFound();
            }
            return View(client);
        }

        //
        // POST: /admin/Default1/Edit/5

        [HttpPost]
        public ActionResult Edit(Client client)
        {
            if (ModelState.IsValid)
            {
                db.Entry(client).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(client);
        }

        //
        // GET: /admin/Default1/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Client client = db.Client.Find(id);
            if (client == null)
            {
                return HttpNotFound();
            }
            return View(client);
        }

        //
        // POST: /admin/Default1/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Client client = db.Client.Find(id);
            db.Client.Remove(client);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}