using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Code_test.Data.Models;
using Code_test.Logic.Models;

namespace Code_test.Logic.Mapper
{
   public static class WidgetMapper
   {
      public static WidgetDTO mapToWidgetDTO(WidgetDAO b)
      {
         var a = new WidgetDTO();
         a.Name = b.Name;
         a.Base_Price = b.Base_Price;
         a.Discount_Indicator = b.Discount_Indicator;
         return a;
      }

      public static WidgetDAO mapToWidgetDAO(WidgetDTO b)
      {
         var a = new WidgetDAO();
         a.Name = b.Name;
         a.Base_Price = b.Base_Price;
         a.Discount_Indicator = b.Discount_Indicator;
         return a;
      }
   }
}
