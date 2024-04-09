using mathquest;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;


namespace mathquest
{

    public class Operations() {

        static void Main(string[] args){
            Sum sum = new Sum();
            Multiples_number multiples = new Multiples_number();

            List<int> result = multiples.GetMultiplesFromNumber(5);
            
            foreach(int num in result)
            {
                Console.WriteLine(num);
            }




        }

    }

}


