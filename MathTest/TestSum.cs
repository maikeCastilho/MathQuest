using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using mathquest;



namespace MathTest
{
    [TestClass]
    public class TestSum
    {
        [TestMethod]
        public void TestSumToIntNumbers()
        {
            Sum sum = new Sum();

            int x = 4;
            int y = 5;

            int result = sum.SumToNumbers(x, y);

            Assert.AreEqual(9, result);

        }


    }
}
