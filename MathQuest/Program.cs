using System.Net.Http.Headers;
using System.Runtime.InteropServices;

namespace mathquests
{

    public class Operations() {

        static void Main(){
            Operations math_ops = new Operations();

            math_ops.ConvertMeters(3.5);
        }

        public double Sum(double a, double b)
        {
            return a + b;
        }

        public List<int> Multiple(int num)
        {

            List<int> multiplos = new List<int>();

            int max_multiple = num * 10;

            for (int i = 1; i <= max_multiple; i++)
            {
                if (i % num == 0)
                { 
                    multiplos.Add(i);
                }
            }

            return multiplos;
        }


        public double ConvertMeters(double meters)
        {

            return meters * 1000;

        }




    }

}


