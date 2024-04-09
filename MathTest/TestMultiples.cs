using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using mathquest;



namespace MathTest
{
    [TestClass]
    public class TestMultiple
    {
        [TestMethod]
        public void TestMultiples()
        {
            //CONSTRUIR
            Multiples_number multiples_numbers = new Multiples_number();

            //OPERAR
            int num = 5;
            List<int> result = multiples_numbers.GetMultiplesFromNumber(num);

            //VERIFICAR
            int last_item = num * 10;

            CollectionAssert.AreEqual(new List<int> { 5, 10, 15, 20, 25, 30, 35, 40, 45, 50 }, result);
            Assert.AreEqual(10, result[1]);
            Assert.AreEqual(50, last_item);
        }


    }
}
