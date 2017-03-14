using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyNumbers {
    public class Program {
        public static void Main(string[] args) {
            for(int i = 0; i < 250;i++ ) {
                TestHappyNumber(i);
            }
            TestHappyNumber(19);
            Console.ReadKey();
        }

        private static void TestHappyNumber(int number) {
            if(number<1){
                Console.WriteLine("Numbers less than 1 are not allowed : {0}", number);
            }else  if(number > 231) {
                Console.WriteLine("Numbers greater than 231 is not allowed: {0}", number);
            }else if(IsHappyNumber(number)) {
                Console.WriteLine("The {0} is a happy number :)",number);
            } else {
                Console.WriteLine("The {0} is not a Happy number T_T",number);
            }
        }

        private static bool IsHappyNumber(int number) {
            string numberCadena=number.ToString();
            List<int> listaNumber = new List<int>();
            int numberHappy = 0;
            while(numberHappy != 1) {
                for(int i = 0; i < numberCadena.Length; i++) {
                    int numVal = Int32.Parse(numberCadena.Substring(i, 1));
                    numberHappy = numberHappy + (numVal * numVal);
                }
                if(listaNumber.Contains(numberHappy)) {
                    return false;
                } else {
                    listaNumber.Add(numberHappy);
                }
                if(numberHappy != 1) {
                    numberCadena = numberHappy.ToString();
                    numberHappy = 0;
                }
            }
            return true;
        }
    }
}