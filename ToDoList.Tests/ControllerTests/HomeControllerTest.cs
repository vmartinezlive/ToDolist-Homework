using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using ToDoList.Controllers;
using ToDoList.Models;

namespace ToDoList.Tests
{
  [TestClass]
  public class HomeControllerTest
  {

  }
}
  [TestMethod]
      public void Index_HasCorrectModelType_ItemList()
      {
          //Arrange
          HomeController controller = new HomeController();
          ViewResult indexView = new HomeController().Index as ViewResult;

          //Act
          ViewResult result = indexView.ViewData.Model;

          //Assert
          Assert.IsInstanceOfType(result, typeof(List<Item>));
      }
