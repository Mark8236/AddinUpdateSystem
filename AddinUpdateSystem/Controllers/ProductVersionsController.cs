using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AddinUpdateSystem.Models;

namespace AddinUpdateSystem.Controllers
{
    public class ProductVersionsController : Controller
    {
        private SWP_SmartCubeEntities db = new SWP_SmartCubeEntities();

        // GET: ProductVersions
        public async Task<ActionResult> Index()
        {
            var t_ProductVersion = db.T_ProductVersion.Include(p => p.T_Product);
            return View(await t_ProductVersion.ToListAsync());
        }

        // GET: ProductVersions/Details/5
        public async Task<ActionResult> Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProductVersion productVersion = await db.T_ProductVersion.FindAsync(id);
            if (productVersion == null)
            {
                return HttpNotFound();
            }
            return View(productVersion);
        }

        // GET: ProductVersions/Create
        public ActionResult Create()
        {
            ViewBag.ProductID = new SelectList(db.T_Product, "ID", "Name");
            return View();
        }

        // POST: ProductVersions/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "ID,ProductID,Major,Minor,Build,Revision,IsBeta,Description,CreatedTime,ChangedTime")] ProductVersion productVersion)
        {
            if (ModelState.IsValid)
            {
                db.T_ProductVersion.Add(productVersion);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ViewBag.ProductID = new SelectList(db.T_Product, "ID", "Name", productVersion.ProductID);
            return View(productVersion);
        }

        // GET: ProductVersions/Edit/5
        public async Task<ActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProductVersion productVersion = await db.T_ProductVersion.FindAsync(id);
            if (productVersion == null)
            {
                return HttpNotFound();
            }
            ViewBag.ProductID = new SelectList(db.T_Product, "ID", "Name", productVersion.ProductID);
            return View(productVersion);
        }

        // POST: ProductVersions/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "ID,ProductID,Major,Minor,Build,Revision,IsBeta,Description,CreatedTime,ChangedTime")] ProductVersion productVersion)
        {
            if (ModelState.IsValid)
            {
                db.Entry(productVersion).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.ProductID = new SelectList(db.T_Product, "ID", "Name", productVersion.ProductID);
            return View(productVersion);
        }

        // GET: ProductVersions/Delete/5
        public async Task<ActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProductVersion productVersion = await db.T_ProductVersion.FindAsync(id);
            if (productVersion == null)
            {
                return HttpNotFound();
            }
            return View(productVersion);
        }

        // POST: ProductVersions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(long id)
        {
            ProductVersion productVersion = await db.T_ProductVersion.FindAsync(id);
            db.T_ProductVersion.Remove(productVersion);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
