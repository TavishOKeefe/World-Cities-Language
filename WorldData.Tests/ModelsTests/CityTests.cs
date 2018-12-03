using Microsoft.VisualStudio.TestTools.UnitTesting;
using Data.Models;
using System.Collections.Generic;
using System;
using MySql.Data.MySqlClient;

namespace Data.Tests
{
  [TestClass]
  public class CityTest : IDisposable
  {
    public void Dispose()
    {
      //City.ClearAll();
    }

    [TestMethod]
    public void CityConstructor_CreatesInstanceOfCity_City()
    {
      City newCity = new City("Fake City Name", 1089);
      Assert.AreEqual(typeof(City), newCity.GetType());
    }
    [TestMethod]
    public void GetName_ReturnsName_String()
    {
      //Arrange
      string name = "Test City";
      int population = 1345;
      City newCity = new City(name, population);

      //Act
      string result = newCity.GetCity();

      //Assert
      Assert.AreEqual(name, result);
    }
  }
}
