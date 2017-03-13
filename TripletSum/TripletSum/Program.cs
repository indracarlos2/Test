using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripletSum {
    class Program {
        public static void Main(string[] args) {
            int[] array = { 14, 1, 2, 3, 8, 15, 3 };
            int[] array2 = { 1, 1, 2, 5, 3 };
            int[] array3 = { 1, 100, 2, 5, 3, 24, 56,89,9,10,18,998,789 };
            TestTripleSum(array,15);
            TestTripleSum(array2, 8);
            TestTripleSum(array3, 795);
            TestTripleSum(array3, 888);  
            TestTripleSum(array3, 666);
            TestTripleSum(array3, 108);
            Console.ReadKey();
        }

        private static void TestTripleSum(int[] array, int number) {
         
            if(!ValidateRangeOfNumber(number)) {
               Console.WriteLine("The number must be in the range 1 to 3000, the current value is: "+number);
               return;
            } 
            if(!ValidateLengthOfArray(array)) {
                Console.WriteLine("The length of the array must be greater or equal than 3 and less or equal than 1000, the current length is: " + array.Length);
                return;
            }
            Array.Sort(array);
            if(!ValidateValuesOfArray(array)) {
                Console.WriteLine("The values of the array must be in the range 1 to 1000");
                Console.WriteLine("Check the values of the array, the array has values out of range.");
                return;
            }
            if(!TripletSum(array, number)) {
                Console.WriteLine("There is not triplet sum with the value: "+ number);
            }
        }

        private static bool ValidateRangeOfNumber(int number) {
            if(number < 1 || number > 3000) {
                return false;
            }
            return true;
        }

        private static bool ValidateLengthOfArray(int[] array) {
            if(array.Length<3||array.Length>1000){
                return false;
            }
            return true;
        }

        private static bool ValidateValuesOfArray(int [] array) {
            if(array[0]<1||array[array.Length-1]>1000){
                return false;
            }
            return true;
        }
        
        private static bool TripletSum(int [] array, int number) {
            int secondPosition, tirdPosition;
            for(int i=0;i<array.Length-2;i++){
                secondPosition = i + 1;
                tirdPosition = array.Length - 1;
                while(secondPosition<tirdPosition){
                    if(array[i]+
                        array[secondPosition]+
                        array[tirdPosition]==number){
                            Console.WriteLine("The triplet sum {0} is with these values  {1}, {2}, {3}",
                                number,
                                array[i],
                                array[secondPosition],
                                array[tirdPosition]);
                            return true;
                    } else if(array[i] +
                              array[secondPosition] +
                              array[tirdPosition] < number) {
                                  secondPosition++;
                    } else {
                        tirdPosition--;
                    }
                }
            }
            return false;
        }
    }
}
