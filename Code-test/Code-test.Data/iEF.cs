using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_test.Data
{
   public interface iEF
   {
      List<Widget> getWidgets();
      bool insertWidget(Widget widget);
      bool updateWidget(Widget widget);
      bool deleteWidget(Widget widget);
      
   }
}
