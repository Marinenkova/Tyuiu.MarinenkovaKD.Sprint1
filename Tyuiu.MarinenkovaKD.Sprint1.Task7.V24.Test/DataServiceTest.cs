using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MarinenkovaKD.Sprint1.Task7.V24.Lib;

namespace Tyuiu.MarinenkovaKD.Sprint1.Task7.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 5;
            double y = 2;
            double wait = 0.302;
            var result = ds.Calculate(x, y);
            Assert.AreEqual(wait, result);
        }
    }
}
