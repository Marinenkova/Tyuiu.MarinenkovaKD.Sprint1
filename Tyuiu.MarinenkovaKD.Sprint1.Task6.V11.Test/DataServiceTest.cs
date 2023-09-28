using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using Tyuiu.MarinenkovaKD.Sprint1.Task6.V11.Lib;

namespace Tyuiu.MarinenkovaKD.Sprint1.Task6.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            string strTest = "Привет";
            DataService ds = new DataService();
            bool res = ds.CheckeFirstLetterRepetition(strTest);
            bool wait = false;
            Assert.AreEqual(wait, res);
        }
    }
}
