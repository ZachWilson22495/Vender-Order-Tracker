using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using VendorOrderTracker.Models;

namespace VendorOrderTracker.Tests
{
  [TestClass]
  public class OrderTests : IDisposable
  {
    public void Dispose()
    {
      Order.ClearAll();
    }

    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order("test", "test", "test", "test");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetOrderDescription_ReturnsOrderDescription_String()
    {
      //Arrange
      string orderName = "beans";
      string orderDescription = "It's beans";
      string orderPrice = "$beans";
      string orderDate = "beans/beans/beans";


      //Act
      Order newOrder = new Order(orderName, orderDescription, orderPrice, orderDate);
      string result = newOrder.OrderDescription;

      //Assert
      Assert.AreEqual(orderDescription, result);
    }

    [TestMethod]
    public void SetDescription_SetDescription_String()
    {
      //Arrange
      string orderName = "beans";
      string orderDescription = "It's beans";
      string orderPrice = "$beans";
      string orderDate = "beans/beans/beans";
      Order newOrder = new Order(orderName, orderDescription, orderPrice, orderDate);

      //Act
      string updatedDescription = "It's no longer beans";
      newOrder.OrderDescription = updatedDescription;
      string result = newOrder.OrderDescription;

      //Assert
      Assert.AreEqual(updatedDescription, result);
    }

    [TestMethod]
    public void GetAll_ReturnsEmptyList_OrderList()
    {
      // Arrange
      List<Order> newList = new List<Order> { };

      // Act
      List<Order> result = Order.GetAll();

      // Assert
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetAll_ReturnsOrders_OrderList()
    {
      //Arrange
      string orderName1 = "beans";
      string orderDescription1 = "It's beans";
      string orderPrice1 = "$beans";
      string orderDate1 = "beans/beans/beans";
      string orderName2 = "NOT BEANS";
      string orderDescription2 = "THERE ARE NO BEANS";
      string orderPrice2 = "$NOT BEANS";
      string orderDate2 = "THERE'S/NO/BEANS";
      Order newOrder1 = new Order(orderName1, orderDescription1, orderPrice1, orderDate1);
      Order newOrder2 = new Order(orderName2, orderDescription2, orderPrice2, orderDate2);
      List<Order> newList = new List<Order> { newOrder1, newOrder2 };

      //Act
      List<Order> result = Order.GetAll();

      //Assert
      CollectionAssert.AreEqual(newList, result);
    }
  }
}