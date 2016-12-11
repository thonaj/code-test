using Code_test.Data;
using Code_test.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Moq;

namespace Code_test.Test
{
   public class DataDAOTests
   {
      [Fact]
      public void insertWidgetDAO_validWidget_returnsTrue()
      {
         //arrange
         var mockEF = new Mock<iEF>();

         mockEF.Setup(m => m.insertWidget(It.IsAny<Widget>())).Returns(true);
         var classToBeTested = new DataAccess(mockEF.Object);

         //act
         var result = classToBeTested.insertWidgetDAO(new WidgetDAO());

         //assert
         Assert.True(result);        
      }
      [Fact]
      public void insertWidgetDAO_invalidWidget_returnsfalse()
      {
         //arrange
         var mockEF = new Mock<iEF>();

         mockEF.Setup(m => m.insertWidget(It.IsAny<Widget>())).Returns(false);
         var classToBeTested = new DataAccess(mockEF.Object);

         //act
         var result = classToBeTested.insertWidgetDAO(new WidgetDAO());

         //assert
         Assert.False(result);
      }

      [Fact]
      public void insertWidgetDAO_calledOnce_true()
      {
         //arrange
         var mockEF = new Mock<iEF>();

         mockEF.Setup(m => m.insertWidget(It.IsAny<Widget>())).Returns(true);
         var classToBeTested = new DataAccess(mockEF.Object);

         //act
         var result = classToBeTested.insertWidgetDAO(new WidgetDAO());

         //assert
         mockEF.Verify(m => m.insertWidget(It.IsAny<Widget>()), Times.Once);
      }
      [Fact]
      public void testupdateWidgetDAO()
      {
         //arrange
         var mockEF = new Mock<iEF>();

         mockEF.Setup(m => m.updateWidget(It.IsAny<Widget>())).Returns(true);
         var classToBeTested = new DataAccess(mockEF.Object);

         //act
         var result = classToBeTested.updateWidgetDAO(new WidgetDAO());

         //assert
         Assert.True(result);
      }

      [Fact]
      public void testdeleteWidgetDAO()
      {
         //arrange
         var mockEF = new Mock<iEF>();
        
         mockEF.Setup(m => m.deleteWidget(It.IsAny<Widget>())).Returns(true);
         var classToBeTested = new DataAccess(mockEF.Object);

         //act
         var result = classToBeTested.deleteWidgetDAO(new WidgetDAO());

         //assert
         Assert.True(result);

        
      }

      [Fact]
      public void testGetWidgetDAOs()
      {
         //arrange
         var mockEF = new Mock<iEF>();
         List<Widget> list = new List<Widget>();
         list.Add(new Widget { Base_Price = 1.99m, Discount_Indicator = false, Name = "mock widget", Id = 33 });
         mockEF.Setup(m => m.getWidgets()).Returns(list);
         var classToBeTested = new DataAccess(mockEF.Object);

         //act
         var result = classToBeTested.getWidgetDAOs();

         //assert
         Assert.NotEmpty(result);
      }
   }
}
