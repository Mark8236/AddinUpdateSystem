using AddinUpdateSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AddinUpdateSystem.Controllers
{
    public class ProductsController : Controller
    {
        private SWP_SmartCubeEntities db = new SWP_SmartCubeEntities();

        // GET: Products
        public ActionResult Index()
        {
            return View();
        }

        [OutputCache(NoStore = true, Duration = 0, VaryByParam = "*")]
        public JsonResult GetProduct()
        {
            var products = new List<ProductInfo>();

            foreach(var p in db.T_Product)
            {
                products.Add(new ProductInfo()
                {
                    ID = p.ID,
                    Name = p.Name,
                    CanSilent = p.CanSilent,
                    HasPrivilege = p.HasPrivilege,
                    PreRunCommand = p.PreRunCommand,
                    PostRunCommand = p.PostRunCommand,
                    AppPreCondition = p.AppPreCondition,
                    GacableAssemblies = p.GacableAssemblies,
                    UnGacableAssemblies = p.UnGacableAssemblies,
                    Description = p.Description,
                });
            }
            return Json(products, JsonRequestBehavior.AllowGet);
        }

        // GET: Products/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Products/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Products/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Products/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Products/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Products/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Products/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
