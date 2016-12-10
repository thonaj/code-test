using Code_test.Logic.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Code_test.Client.Models
{
   
   public class Code_testModel
   {
      
      public WidgetDTO MyWidget { get; set; }

      public List<SelectListItem> MySelections { get; set; }

      [Required(ErrorMessage = "You Must Select A Widget")]     
      public string SelectedWidget { get; set; }

      [Required(ErrorMessage = "You Must Sselect A Quantity")]      
      public int Quantity { get; set; }

      [Required(ErrorMessage ="State is required")]
      [MaxLength(2,ErrorMessage ="Max Length is 2")]
      public string State { get; set; }

      public decimal TaxRate { get; set; }

      public decimal Discount { get; set; }

      public decimal Tax { get; set; }

      public decimal Total { get; set; }
   }
}