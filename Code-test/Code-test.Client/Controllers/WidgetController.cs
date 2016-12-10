using Code_test.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Code_test.Data;
using Code_test.Logic.Models;
using Code_test.Client.Models;

namespace Code_test.Client.Controllers
{
    public class WidgetController : Controller
    {
      private iAppLogic appLogic = new appLogic(new DataAccess(new EF()));
      private Code_testModel testModel= new Code_testModel();

      // GET: Widget
      public ActionResult Index()
      {
         testModel.MySelections = makeWidgetList(appLogic.getWidgetDTOs());
         TempData["model"] = testModel;
         return View(testModel);
      }

      [HttpPost]
      public ActionResult Index(Code_testModel model)
      {
         testModel = TempData["model"] as Code_testModel;
         testModel.Quantity = model.Quantity;
         testModel.State = model.State;
         testModel.SelectedWidget = model.SelectedWidget;
         testModel.MyWidget = appLogic.getWidgetDTOs().Where(m => m.Name.Equals(testModel.SelectedWidget)).FirstOrDefault();
            
         if (ModelState.IsValid)
         {
            TempData["model"] = testModel;
            return RedirectToAction(string.Format("Details/{0}", testModel.MyWidget.Name));
         }
         else
         {
            TempData["model"] = testModel;
            return View(testModel);
         }
            
         

      }
      // GET: Widget/Details/Name
      public ActionResult Details(string id)
      {
         testModel = TempData["model"] as Code_testModel;
         return View();
      }

      // GET: Widget/Create
      public ActionResult Create()
      {
         return View();
      }

      // POST: Widget/Create
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

      // GET: Widget/Edit/5
      public ActionResult Edit(int id)
      {
         return View();
      }

      // POST: Widget/Edit/5
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

      // GET: Widget/Delete/5
      public ActionResult Delete(int id)
      {
         return View();
      }

      // POST: Widget/Delete/5
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

      public List<SelectListItem> makeWidgetList(List<WidgetDTO> result)
      {
         var list = new List<SelectListItem>();
         list.Add(new SelectListItem() { Text = "Please Select A Widget", Value = "notSelected" });
         foreach (var item in result)
         {
            var itm = new SelectListItem();
            itm.Text = item.Name.ToUpper();
            itm.Value = item.Name;            
            list.Add(itm);
         }
         return list;
      }

   }
}
