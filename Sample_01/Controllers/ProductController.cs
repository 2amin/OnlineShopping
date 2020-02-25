using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Sample_01.Controllers
{
    public class ProductController : Controller
    {
        #region [-Ctor-]
        public ProductController()
        {
            Ref_ProductCrud = new Models.DomainModel.POCO.ProductCrud();
        }
        #endregion
        #region [-Props-]
        public Models.DomainModel.POCO.ProductCrud Ref_ProductCrud { get; set; }
        #endregion
        #region [-Index()-]
        // GET: Product
        [HttpGet]
        public ActionResult Index()
        {
            return View(Ref_ProductCrud.Select());
        }
        #endregion
        #region [-Edit-]
        #region [- Get -]
        [HttpGet]
       
        public ActionResult Edit(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var person = Ref_ProductCrud.Find(id);
            if (person == null)
            {
                return HttpNotFound();
            }
            return View(person);
        }
        #endregion



        #region [- Post -]

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Models.DomainModel.DTO.EF.Product product)
        {
            if (ModelState.IsValid)
            {
                Ref_ProductCrud.Update(product);
                return RedirectToAction("Index");
            }
            return View(product);
        }
        #endregion 
        #endregion

    }

}

