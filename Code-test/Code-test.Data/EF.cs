using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_test.Data
{
    public class EF
    {
      private Entities ef = new Entities();

      public List<Widget> getWidgets()
      {
         return ef.Widgets.ToList();
      }

      public bool insertWidget(Widget widget)
      {
         ef.Widgets.Add(widget);
         return ef.SaveChanges() > 0;
      }

      public bool updateWidget(Widget widget)
      {
         return changeWidget(widget, EntityState.Modified);
      }

      public bool deleteWidget(Widget widget)
      {
         return changeWidget(widget, EntityState.Deleted);
      }

      private bool changeWidget(Widget itm, EntityState state)
      {
         var item = getWidgets().Where(m => m.Name.Equals(itm.Name)).FirstOrDefault();
         item.Base_Price = itm.Base_Price;
         item.Discount_Indicator = item.Discount_Indicator;
         var entry = ef.Entry<Widget>(item);
         entry.State = state;
         return ef.SaveChanges() > 0;
      }
   }
}
