using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AirlinesReservation
{
    [TestClass]
    public class TestCase1
    {
        [TestMethod]
        public void Case1()
        {
            string UserName = "admin";
            string Password = UserName+ "123"; 
            Assert.AreEqual("admin123", Password);
        }
        [TestMethod]
        public void Case2()
        {
            string UserName = "admin";
            string Password = UserName + "123456";
            Assert.AreEqual("admin123", Password);
        }
        [TestMethod]
        public void Case3()
        {
            string UserName = "mert";
            string Password = UserName + "123";
            Assert.AreEqual("mert", Password);
        }
        [TestMethod]
        public void Case4()
        {
            string UserName = "mert";
            string Password = UserName + " ";
            Assert.AreEqual("mert ", Password);
        }
        [TestMethod]
        public void Case5()
        {
            string UserName = "admin";
            string Password = UserName + "123";
            Assert.AreEqual("admin123", Password);
        }
        [TestMethod]
        public void Case6()
        {
            int ticket = 5;
            int ticketResult = ticket + 5;
            Assert.AreEqual(10, ticketResult);
        }
        [TestMethod]
        public void Case7()
        {
            string Departure = "26.05.2016";
            string ReturnDate = Departure + " ";
            Assert.AreEqual("26.05.2016 ", ReturnDate);
        }
        [TestMethod]
        public void Case8()
        {
            string Departure = "01.12.2100";
            string ReturnDate = Departure + " 31.12.2053";
            Assert.AreEqual("26.05.2016 ", ReturnDate);
        }
        [TestMethod]
        public void Case9()
        {
            bool control = true;
            bool controlFlight = !control;
            Assert.AreEqual(false, controlFlight);
        }
        [TestMethod]
        public void Case10()
        {
            bool control = true;
            bool controlFlight = !control;
            Assert.AreEqual(true, controlFlight);
        }

        [TestMethod]
        public void Case11()
        {
            int child = 10;
            int childResult = child + 12;
            Assert.AreEqual(10, childResult);
        }
        [TestMethod]
        public void Case12()
        {
            string cabin = "economy";
            string cabinResult = cabin + " ";
            Assert.AreEqual("economy ", cabinResult);
        }
        [TestMethod]
        public void Case13()
        {
            string cabin = "business";
            string cabinResult = cabin + " ";
            Assert.AreEqual("business ", cabinResult);
        }
        [TestMethod]
        public void Case14()
        {
            int hour = 50;
            int hourResult = hour + 50;
            Assert.AreEqual(100, hourResult);
        }
        [TestMethod]
        public void Case15()
        {
            int hour = 175;
            int hourResult = hour + 150;
            Assert.AreEqual(175, hourResult);
        }
        [TestMethod]
        public void Case16()
        {
            string Pass = "integer";
            string Password = Pass + "string";
            Assert.AreEqual("integer", Password);
        }
        [TestMethod]
        public void Case17()
        {
            string Pass = "integer";
            string Password = Pass + " ";
            Assert.AreEqual("integer ", Password);
        }
        [TestMethod]
        public void Case18()
        {
            string Pass = "string";
            string Password = Pass + " ";
            Assert.AreEqual("string ", Password);
        }
        [TestMethod]
        public void Case19()
        {
            string Add = "integer";
            string Address = Add + " ";
            Assert.AreEqual("integer ", Address);
        }
        [TestMethod]
        public void Case20()
        {
            string Add = "string";
            string Address = Add + " ";
            Assert.AreEqual("string ", Address);
        }
    }
}
