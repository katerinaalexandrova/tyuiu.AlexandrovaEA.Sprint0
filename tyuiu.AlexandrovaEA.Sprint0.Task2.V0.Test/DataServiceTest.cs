using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using tyuiu.AlexandrovaEA.Sprint0.Task2.V0.Lib;

namespace tyuiu.AlexandrovaEA.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessegeValid()
        {
            string name = "Катя";
            var res = DataService.GetMessege(name);
            Assert.AreEqual("Привет, Катя", res);
        }
    }
}
