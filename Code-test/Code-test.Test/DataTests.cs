using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Code_test.Data.Models;
using Code_test.Data;
using Moq;

namespace Code_test.Test
{
    public class DataTests
    {
      private EF da = new EF();
      [Fact]
      public void testinsertWidget()
      {
         var widget = new Widget();
         widget.Name = "test";
         widget.Base_Price = 1.99m;
         widget.Discount_Indicator = false;
         var result = da.insertWidget(widget);
         Assert.True(result);
      }
      [Fact]
      public void testupdateWidget()
      {
         var widget = new Widget();
         widget.Name = "test";
         
         var actual = da.getWidgets().Where(m => m.Name.Equals(widget.Name)).FirstOrDefault();
         actual.Base_Price = 10.99m;
         var result = da.updateWidget(actual);
         Assert.True(result);
      }

      [Fact]
      public void testdeleteWidget()
      {
         var widget = new Widget();
         widget.Name = "test";        
         var actual = da.getWidgets().Where(m => m.Name.Equals(widget.Name)).FirstOrDefault();
         var result = da.deleteWidget(actual);
         Assert.True(result);
      }

      [Fact]
      public void testGetWidgets()
      {
                  
         var result = da.getWidgets();
         Assert.NotEmpty(result);
      }
   }
}
