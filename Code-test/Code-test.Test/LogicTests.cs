﻿using Code_test.Data;
using Code_test.Data.Models;
using Code_test.Logic;
using Code_test.Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
namespace Code_test.Test
{
   public class LogicTests
   {
      private iAppLogic al = new appLogic(new DataAccess(new EF()));
      
      [Fact]
      public void testinsertWidgetDTO()
      {         
         var widget = new WidgetDTO();
         widget.Name = "test3";
         widget.Base_Price = 3.99m;
         widget.Discount_Indicator = true;
         var result = al.insertWidgetDTO(widget);
         Assert.True(result);
      }
      [Fact]
      public void testupdateWidgetDTO()
      {
         var widget = new WidgetDTO();
         widget.Name = "test";

         var actual = al.getWidgetDTOs().Where(m => m.Name.Equals(widget.Name)).FirstOrDefault();
         actual.Base_Price = 10.99m;
         var result = al.updateWidgetDAO(actual);
         Assert.True(result);
      }

      [Fact]
      public void testdeleteWidgetDTO()
      {
         var widget = new WidgetDTO();
         widget.Name = "test";
         var actual = al.getWidgetDTOs().Where(m => m.Name.Equals(widget.Name)).FirstOrDefault();
         var result = al.deleteWidgetDAO(actual);
         Assert.True(result);
      }

      [Fact]
      public void testGetWidgetDTOs()
      {
         var result = al.getWidgetDTOs();
         Assert.NotEmpty(result);
      }
   }
}
