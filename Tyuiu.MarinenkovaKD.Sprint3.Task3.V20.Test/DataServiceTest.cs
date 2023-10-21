using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MarinenkovaKD.Sprint3.Task3.V20.Lib;

namespace Tyuiu.MarinenkovaKD.Sprint3.Task3.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetCharCount()
        {
            DataService ds = new DataService();

            string str = "gfft ntf f opf";
            char chr = 'f';

            double res = ds.GetCharCount(str, chr);

            int wait = 5;

            Assert.AreEqual(wait, res);
        }
    }
}
