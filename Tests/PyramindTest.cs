using net_lab1_2.lab2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    [TestClass]
    public class PyramindTest
    {
        [TestMethod]
        public void Volume1()
        {
            Pyramid p = new Pyramid(3, 4, 6);
            Assert.AreEqual(24.0, p.volume(), 0.0001);
        }

        [TestMethod]
        public void Volume2()
        {
            Pyramid p = new Pyramid(2, 5, 3);
            Assert.AreEqual(10.0, p.volume(), 0.0001);
        }

        [TestMethod]
        public void SlantA()
        {
            Pyramid p = new Pyramid(6, 8, 3);
            Assert.AreEqual(5.0, p.slantHeightA(), 0.0001);
        }

        [TestMethod]
        public void SlantB()
        {
            Pyramid p = new Pyramid(6, 8, 3);
            Assert.AreEqual(Math.Sqrt(18), p.slantHeightB(), 0.0001);
        }

        [TestMethod]
        public void Area()
        {
            Pyramid p = new Pyramid(6, 8, 3);
            double expected = 48 + 30 + 8 * Math.Sqrt(18);
            Assert.AreEqual(expected, p.area(), 0.0001);
        }

        [TestMethod]
        public void Zero()
        {
            Pyramid p = new Pyramid(0, 0, 0);
            Assert.AreEqual(0.0, p.volume(), 0.0001);
            Assert.AreEqual(0.0, p.area(), 0.0001);
        }
    }
}
