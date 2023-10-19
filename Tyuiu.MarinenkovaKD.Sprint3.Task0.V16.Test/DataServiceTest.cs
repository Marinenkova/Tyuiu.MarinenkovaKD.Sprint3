using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MarinenkovaKD.Sprint3.Task0.V16.Lib;

namespace Tyuiu.MarinenkovaKD.Sprint3.Task0.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultiplySeries()
        {
            DataService ds = new DataService();

            int startValue = 1;
            int stopValue = 11;

            double res = ds.GetMultiplySeries(startValue, stopValue);
            double wait = 6.36014700928697E+22;
            Assert.AreEqual(wait, res);
        }
    }
}
