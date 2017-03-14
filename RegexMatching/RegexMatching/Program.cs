using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegexMatching {
    public class Program {
        public static void Main(string[] args) {
            TestIsRegexMatching("^code", "codefights");
            TestIsRegexMatching("hts$", "codefights");
            TestIsRegexMatching("hello", "world");
            TestIsRegexMatching("^hello$", "hello");
            TestIsRegexMatching("^hello$", "hellos");
            TestIsRegexMatching("^cadena", "caden");
            TestIsRegexMatching("cadena$", "cadenas");

            TestIsRegexMatching("", "cadenas");
            TestIsRegexMatching("cadena$", "");
            TestIsRegexMatching("cadenaqwertyuiopasdfghjklzxcvbnm"+
                                "cadenaqwertyuiopasdfghjklzxcvbnm"+
                                "cadenaqwertyuiopasdfghjklzxcvbnm"+
                                "cadenaqwertyuiopasdfghjklzxcvbnm$", "cadenas");
            TestIsRegexMatching("cadena$",  "cadenaqwertyuiopasdfghjklzxcvbnm"+
                                            "cadenaqwertyuiopasdfghjklzxcvbnm"+
                                            "cadenaqwertyuiopasdfghjklzxcvbnm"+
                                            "cadenaqwertyuiopasdfghjklzxcvbnm$");
            Console.ReadKey();
        }

        private static void TestIsRegexMatching(string pattern, string test) {
            Console.WriteLine("The pattern is '{0}' and the test is '{1}': Is it matching?:{2}",
                pattern, test, IsRegexMatching(pattern,test));
        }

        private static bool IsRegexMatching(string pattern, string test) {
            string starting = "^";
            string ending = "$";
            bool result = false;
            if(!ValidateMimimumLength(pattern,"The pattern must have at least one character.")||
               !ValidateMimimumLength(test,"The test must have at least one character.")||
               !ValidateMaximumLength(pattern,
               "The pattern must have a maximum of 105 characters, length {0}")||
               !ValidateMaximumLength(test,
               "The test must have a maximum of 105 characters, length {0}")) {
                return false;
            }
         
            if(pattern.StartsWith(starting)&&
                pattern.EndsWith(ending)) {
                if((starting + test + ending).Equals(pattern)) {
                    result = true;
                } else {
                    result = false;
                }
            }
            else if(pattern.StartsWith(starting)&&
               (starting+test).StartsWith(pattern)) {
                    result = true;
            } 
            else if(pattern.EndsWith(ending)&&
                (test+ending).EndsWith(pattern)) {
                    return true;
            } else if(test.Contains(pattern)){
                result = true;
            }
            return result;
        }

        private static bool ValidateMimimumLength(string cadena, string message) {
            if(cadena.Length < 1) {
                Console.WriteLine(message);
                return false;
            }
            return true;
        }

        private static bool ValidateMaximumLength(string cadena, string message) {
            if(cadena.Length > 105) {
                Console.WriteLine(message, cadena.Length);
                return false;
            }
            return true;
        }
    }
}