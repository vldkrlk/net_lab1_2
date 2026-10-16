using net_lab1_2.lab2;

namespace Tests
{
    [TestClass]
    public sealed class Calculator1Test
    {
        [TestMethod]
        public void Calculation_all_less_than_five()
        {
            var c = new Calculator1(1, 2, 3);

            var result = c.Calculate();

            Assert.AreEqual(6, result);
        }

        [TestMethod]
        public void Calculation_one_greater_than_five()
        {
            var c = new Calculator1(1, 2, 6);
            var result = c.Calculate();
            Assert.AreEqual(729, result);
        }
        [TestMethod]
        public void Calculation_all_greater_than_five()
        {
            var c = new Calculator1(6, 7, 8);
            var result = c.Calculate();
            Assert.AreEqual(9261, result);
        }
        [TestMethod]
        public void Calculation_all_five()
        {
            var c = new Calculator1(5, 5, 5);
            var result = c.Calculate();
            Assert.AreEqual(15, result);
        }
    }
}
