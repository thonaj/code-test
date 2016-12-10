using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Code_test.Client.Models
{
   public class WidgetDTO
   {
      public string Name { get; set; }
      public decimal Base_Price { get; set; }
      public bool Discount_Indicator { get; set; }
   }
}