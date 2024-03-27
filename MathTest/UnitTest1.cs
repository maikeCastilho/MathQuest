using mathquests;
using System.Buffers;

namespace MathTest
{   
    [TestClass]
    public class SumTest
    {
        Operations mathOps = new Operations();

        [TestMethod]
        public void sum_with_int_numbers()
        {
            double result = mathOps.Sum(4, 5);
            Assert.AreEqual(9, result);           
        }

        [TestMethod]
        public void sum_with_float_numbers()
        {
            double result = mathOps.Sum(2.5, 2.5);
            Assert.AreEqual(5, result);
        }
    }


    [TestClass]
    public class MutipleTest
    {
        Operations mathOps = new Operations();
            
        [TestMethod]
        public void test_multiples_numbers()
        {
            List<int> multiples = mathOps.Multiple(3);
            Assert.AreEqual(10, multiples.Count);
        }
    }


    [TestClass]
    public class ConvertTest
    {
        Operations mathOps = new Operations();

        [TestMethod]
        public void test_convert_meters_to_milims()
        {
            double result = mathOps.ConvertMeters(30);
            Assert.AreEqual(30000, result);

            double result_g = mathOps.ConvertMeters(1.5);
            Assert.AreEqual(1500, result_g);
        }


    }



}






