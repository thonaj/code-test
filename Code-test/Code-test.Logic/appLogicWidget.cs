using Code_test.Data;
using Code_test.Data.Models;
using Code_test.Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_test.Logic
{
   public partial class appLogic:iAppLogic
   {
      public iDataAccess da;
      public appLogic(iDataAccess iDa)
      {
         da = iDa;
      }

      public List<WidgetDTO> getWidgetDTOs()
      {
        
         var list = new List<WidgetDTO>();
         var widgets = da.getWidgetDAOs();
         foreach (var item in widgets)
         {
            list.Add(Mapper.WidgetMapper.mapToWidgetDTO(item));
         }
         return list;
      }

      public bool insertWidgetDTO(WidgetDTO widget)
      {
         return da.insertWidgetDAO(Mapper.WidgetMapper.mapToWidgetDAO(widget));
      }

      public bool deleteWidgetDAO(WidgetDTO widget)
      {
         return da.deleteWidgetDAO(Mapper.WidgetMapper.mapToWidgetDAO(widget));
      }

      public bool updateWidgetDAO(WidgetDTO widget)
      {
         return da.updateWidgetDAO(Mapper.WidgetMapper.mapToWidgetDAO(widget));
      }
   }
}
