using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodStrings {
    public class Program {
        
        public static void Main(string[] args) {
            string[] dictionary=new string[]{"a","b","c","d","e",
                                                "f","g","h","i","j",
                                                "k","l","m","n","o",
                                                "p","q","r","s","t",
                                                "u","v","w","x","y","z" };
            //I made two way to calculate the number GoodStrings  the first is creating 
            //of all GoodString with the method TestNumberOfGoodString, the second way is
            //using the method TestNumberOfGoodStringEstadistic, this method calculates the
            //number of GoodString without make any GoodString only use one estadistic
            //algoritm for this.
            GoodString goodString = new GoodString(dictionary);
            int len = 1;
            while(len < 10) {
                goodString.TestNumberOfGoodString(len);
                len++;
            }
            len = 1;
            Console.WriteLine();
            while(len < 10) {
                goodString.TestNumberOfGoodStringEstadistic(len);
                len++;
            }
            Console.WriteLine();
            Console.ReadKey();
        }

       
    }
}