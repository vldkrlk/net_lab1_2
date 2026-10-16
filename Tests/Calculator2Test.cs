using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using net_lab1_2.lab2;

namespace Tests
{
    [TestClass]
    public class Calculator2Test
    {
        [TestMethod]
        public void Calculate_MultipliesMatchingNumbers()
        {
            // 2, 7, 11
            var c = new Calculator2(1, 11);

            Assert.AreEqual(154, c.Calculate());
        }

        [TestMethod]
        public void Calculate_NoMatchingNumbers_ReturnsOne()
        {
            // Жодне число не відповідає умовам
            var c = new Calculator2(3, 4);

            Assert.AreEqual(1, c.Calculate());
        }

        [TestMethod]
        public void Calculate_NumberMatchesBothConditions()
        {
            // 22 відповідає обом умовам: 22 * 22 = 484
            var c = new Calculator2(22, 22);

            Assert.AreEqual(484, c.Calculate());
        }

        [TestMethod]
        public void Calculate_ZeroInRange()
        {
            var c = new Calculator2(0, 0);
            Assert.AreEqual(0, c.Calculate());
        }
    }
}
