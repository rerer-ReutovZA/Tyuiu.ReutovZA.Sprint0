using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ReutovZA.Sprint0.Task2.V0.Lib;
namespace Tyuiu.ReutovZA.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Захар";
            var res = DataService.GetMessage(name);
            Assert.AreEqual("Привет,Захар", res);
        }
    }
}
