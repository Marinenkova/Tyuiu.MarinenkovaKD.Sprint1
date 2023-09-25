using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.MarinenkovaKD.Sprint1.Task4.V23.Lib;

namespace Tyuiu.MarinenkovaKD.Sprint1.Task4.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 2;
            double wait = 2;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
