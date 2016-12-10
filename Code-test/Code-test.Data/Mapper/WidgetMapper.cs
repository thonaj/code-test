using Code_test.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Code_test.Data.Mapper
{
   public class WidgetMapper
   {
      public static Widget mapToWidget(WidgetDAO b)
      {
         var a = new Widget();
         a.Name = b.Name;
         a.Base_Price = b.Base_Price;
         a.Discount_Indicator = b.Discount_Indicator;
         return a;
      }

      public static WidgetDAO mapToWidgetDAO(Widget b)
      {
         var a = new WidgetDAO();
         a.Name = b.Name;
         a.Base_Price = b.Base_Price;
         a.Discount_Indicator = b.Discount_Indicator;
         return a;
      }

   }
}
