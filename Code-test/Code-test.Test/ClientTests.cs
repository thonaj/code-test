using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using Code_test.Logic;
using Code_test.Client;
using Code_test.Logic.Models;
using Code_test.Client.Controllers;
using System.Web.Mvc;
using Xunit;
using Code_test.Client.Models;

namespace Code_test.Test
{
   public class ClientTests
   {
      [Fact]
      public void makeWidgetLIst_getsValidWidgetLIst_returnListSelectItems()
      {
         //arrange
         var mockapplogic = new Mock<iAppLogic>();
         List<WidgetDTO> list = new List<WidgetDTO>();
         list.Add(new WidgetDTO { Base_Price = 1.99m, Discount_Indicator = false, Name = "test widgetdto" });
         mockapplogic.Setup(m => m.getWidgetDTOs()).Returns(list);
         var classToBeTested = new WidgetController(mockapplogic.Object);
         
         
         //act
         var result = classToBeTested.makeWidgetList(list);

         //assert
         Assert.NotEmpty(result);
      }

      [Fact]
      public void index_returnViewResult()
      {
         //arrange
         var mockapplogic = new Mock<iAppLogic>();
         List<WidgetDTO> list = new List<WidgetDTO>();
         list.Add(new WidgetDTO { Base_Price = 1.99m, Discount_Indicator = false, Name = "test widgetdto" });
         mockapplogic.Setup(m => m.getWidgetDTOs()).Returns(list);
         var classToBeTested = new WidgetController(mockapplogic.Object);


         //act
         var result = (ViewResult)classToBeTested.Index();

         //assert
         Assert.NotNull(result);
      }

     
   }
}
