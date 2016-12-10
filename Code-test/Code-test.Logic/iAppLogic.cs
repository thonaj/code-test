using Code_test.Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_test.Logic
{
   public interface iAppLogic
   {
      List<WidgetDTO> getWidgetDTOs();
      bool insertWidgetDTO(WidgetDTO widget);
      bool deleteWidgetDAO(WidgetDTO widget);
      bool updateWidgetDAO(WidgetDTO widget);
      decimal calculateDiscount(WidgetDTO itm);
      decimal getTaxRate(WidgetDTO itm, string state);
      decimal calculateTax(WidgetDTO itm, decimal taxRate, int quanity, decimal discount);
      decimal calculateTotal(WidgetDTO itm, decimal discount, decimal tax, int quantity);
   }
}
