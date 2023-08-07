using Microsoft.VisualStudio.TestTools.UnitTesting;
using YksikkötestiDemo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YksikkötestiDemo.Tests
{
    [TestClass()]
    public class LaskeSummaTests
    {
        [TestMethod()]
        public void SummaTest()
        {
            int luku1 = 123;
            int luku2 = 234;

            LaskeSumma laske = new();
            int summa = laske.Summa(luku1, luku2);

            Assert.AreEqual(luku1 + luku2, summa);
        }
    }
}