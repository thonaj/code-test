using Code_test.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_test.Data
{
   public class DataAccess
   {
      private EF ef = new EF();
      public List<WidgetDAO> getWidgetDAOs()
      {
         var list = new List<WidgetDAO>();
         var widgets = ef.getWidgets();
         foreach (var item in widgets)
         {
            list.Add(Mapper.WidgetMapper.mapToWidgetDAO(item));
         }
         return list;
      }

      public bool insertWidgetDAO(WidgetDAO widget)
      {
         return ef.insertWidget(Mapper.WidgetMapper.mapToWidget(widget));
      }

      public bool deleteWidgetDAO(WidgetDAO widget)
      {
         return ef.deleteWidget(Mapper.WidgetMapper.mapToWidget(widget));
      }

      public bool updateWidgetDAO(WidgetDAO widget)
      {
         return ef.updateWidget(Mapper.WidgetMapper.mapToWidget(widget));
      }
   }
}
