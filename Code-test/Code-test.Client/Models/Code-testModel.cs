using Code_test.Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Code_test.Client.Models
{
   public class Code_testModel
   {
      public Code_testModel()
      {
         MyWidgets = new List<WidgetDTO>();
         
      }
      public List<WidgetDTO> MyWidgets { get; set; }
      public List<SelectListItem> MySelections { get; set; }
      public string SelectedWidget { get; set; }
      public int Quantity { get; set; }
      public string State { get; set; }
      public decimal TaxRate { get; set; }
      public decimal Discount { get; set; }
      public decimal Tax { get; set; }
      public decimal Total { get; set; }
   }
}