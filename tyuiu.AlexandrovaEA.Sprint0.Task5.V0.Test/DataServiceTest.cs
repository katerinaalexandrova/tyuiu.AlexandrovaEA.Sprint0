using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using tyuiu.AlexandrovaEA.Sprint0.Task5.V0.Lib;

namespace tyuiu.AlexandrovaEA.Sprint0.Task5.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckAddValid()
        {
            Assert.AreEqual(10, DataService.Add(5, 5));
        }

        [TestMethod]
        public void CheckSubValid()
        {
            Assert.AreEqual(5, DataService.Sub(10, 5));
        }

        [TestMethod]
        public void CheckMultValid()
        {
            Assert.AreEqual(50, DataService.Mult(10, 5));
        }
        [TestMethod]
        public void CheckDivValid()
        {
            Assert.AreEqual(3, DataService.Div(9, 3));
        }
    }
}
