using Code_test.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_test.Data
{
   public interface iDataAccess
   {
      List<WidgetDAO> getWidgetDAOs();
      bool insertWidgetDAO(WidgetDAO widget);
      bool deleteWidgetDAO(WidgetDAO widget);
      bool updateWidgetDAO(WidgetDAO widget);
   }
}
