using Code_test.Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_test.Logic
{
    public partial class appLogic
    {
      public decimal calculateDiscount(WidgetDTO itm)
      {
         if (itm.Discount_Indicator)
         {
            return 0.10m;
         }
         else return 0.00m;
      }

      public decimal getTaxRate(WidgetDTO itm, string state)
      {
         if (!state.ToUpper().Equals("TX") && !state.ToUpper().Equals("FL"))
         {
            return .05m;
         }
         else return 0.00m;
      }

      public decimal calculateTax(WidgetDTO itm, decimal taxRate, int quanity, decimal discount)
      {
         return ((itm.Base_Price - discount) * quanity) * taxRate;
      }

      public decimal calculateTotal(WidgetDTO itm, decimal discount, decimal tax, int quantity)
      {
         return ((itm.Base_Price - discount) * quantity) + tax;
      }

    }
}
