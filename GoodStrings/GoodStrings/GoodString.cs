
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodStrings {

    public class GoodString {
        private Dictionary<string, int> indexDictionary;
        private string[] dictionary;
        public GoodString(string [] dictionary) {
            this.dictionary = dictionary;
            GenerateIndexDictionary();
        }
        private void GenerateIndexDictionary() {
            indexDictionary = new Dictionary<string, int>();
            for(int i = 0; i < dictionary.Length; i++) {
                indexDictionary.Add(dictionary[i], i);
            }
        }

        public  void TestNumberOfGoodStringEstadistic(int len) {
            if(len < 1 || len > 9) {
                Console.WriteLine("Please check the value for len ,GoodString only allows the len number in the range of 1 to 9");
                Console.WriteLine("The value of the len is  {0}", len);
                return;
            }
            Console.WriteLine("Estadistic: The number of GoodStrings is {0} for len {1}",
                Decimal.ToInt32(NumberOfGoodStringEstadistic(len, 1, dictionary.Length)),
                len);
        }

        private  decimal NumberOfGoodStringEstadistic(int len,
                                                        decimal index,
                                                        decimal PreviousNumberGoodString) {
            if(len == 1) {
                return 0;
            }
            decimal lengthBase = dictionary.Length;
            decimal lengthAux = lengthBase - index;
            decimal multiple = lengthAux / (index + 1);
            decimal numberGoodString = PreviousNumberGoodString * multiple;
            if(len > 2) {
                len--;
                index++;
                numberGoodString = NumberOfGoodStringEstadistic(len, index, numberGoodString);
            }
            return numberGoodString;
        }

        public  void TestNumberOfGoodString(int len) {
            if(len < 1 || len > 9) {
                Console.WriteLine("Please check the value for len ,GoodString only allows the len number in the range of 1 to 9");
                Console.WriteLine("The value of the len is  {0}", len);
                return;
            }
            Console.WriteLine("The number of GoodStrings is {0} for len {1}",
                               NumberOfGoodString(len),
                               len);
        }

        private  int NumberOfGoodString(int len) {
            if(len == 1) {
                return 0;
            }
            List<string> list = GenerateCombination(dictionary);
            for(int i = 0; i < len - 2; i++) {
                list = GenerateCombination(list.ToArray());
            }
            return list.Count;
        }

        private List<string> GenerateCombination(string[] baseDictionary) {
            List<string> goodString = new List<string>();
            for(int i = 0; i < baseDictionary.Length; i++) {
                string lastLetter = baseDictionary[i].Substring(baseDictionary[i].Length - 1);
                int index = indexDictionary[lastLetter];
                for(int j = index + 1; j < dictionary.Length; j++) {
                    goodString.Add(baseDictionary[i] + dictionary[j]);
                }
            }
            return goodString;
        }
    }
}