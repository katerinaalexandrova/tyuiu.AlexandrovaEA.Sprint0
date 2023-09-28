using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using tyuiu.AlexandrovaEA.Sprint0.Task6.V0.Lib;

namespace tyuiu.AlexandrovaEA.Sprint0.Task6.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckAddArrValid()
        {
            var numbers = new int[] { 1, 2, 3, 4, 5 };
            var res = DataService.AddArr(numbers);
            Assert.AreEqual(15, res);
        }
        [TestMethod]
        public void CheckSubstrArrValid()
        {
            var numbers = new int[] { 1, 2, 3, 4, 5 };
            var res = DataService.SubstrArr(numbers);
            Assert.AreEqual(-15, res);
        }
        [TestMethod]
        public void CheckMultArrValid()
        {
            var numbers = new int[] { 1, 2, 3, 4, 5 };
            var res = DataService.MultArr(numbers);
            Assert.AreEqual(120, res);
        }
    }
}
