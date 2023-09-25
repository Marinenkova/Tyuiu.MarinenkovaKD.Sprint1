using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.MarinenkovaKD.Sprint1.Task3.V13.Lib;

namespace Tyuiu.MarinenkovaKD.Sprint1.Task3.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double number = (123 % 10) * ((123 / 10) % 10) * ((123 / 100) % 10);
            var res = ds.MultiplyOfDigits(number);
            Assert.AreEqual(6, res);
        }
    }
}
