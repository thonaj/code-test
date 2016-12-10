using Code_test.Data;
using Code_test.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Code_test.Test
{
   public class DataDAOTests
   {
      private DataAccess da = new DataAccess();

      [Fact]
      public void testinsertWidgetDAO()
      {
         var widget = new WidgetDAO();
         widget.Name = "test";
         widget.Base_Price = 1.99m;
         widget.Discount_Indicator = false;
         var result = da.insertWidgetDAO(widget);
         Assert.True(result);
      }
      [Fact]
      public void testupdateWidgetDAO()
      {
         var widget = new WidgetDAO();
         widget.Name = "test";

         var actual = da.getWidgetDAOs().Where(m => m.Name.Equals(widget.Name)).FirstOrDefault();
         actual.Base_Price = 10.99m;
         var result = da.updateWidgetDAO(actual);
         Assert.True(result);
      }

      [Fact]
      public void testdeleteWidgetDAO()
      {
         var widget = new Widget();
         widget.Name = "test";
         var actual = da.getWidgetDAOs().Where(m => m.Name.Equals(widget.Name)).FirstOrDefault();
         var result = da.deleteWidgetDAO(actual);
         Assert.True(result);
      }

      [Fact]
      public void testGetWidgetDAOs()
      {
         var result = da.getWidgetDAOs();
         Assert.NotEmpty(result);
      }
   }
}
