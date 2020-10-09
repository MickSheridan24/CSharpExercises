using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExercises {
    class Program {
        static void Main(string[] args) 
        { 
 
            var arr = new int[] {1, 5, 2, 6, 1, 10};
            PrintCountsAboveAndBelowValueLinq(arr, 6);
            PrintCountsAboveAndBelowValueFast(arr, 6);

            for (var x = -10; x < 10; x++) {
                Console.WriteLine(x + ": " + RotateCharactersInString("MyString", x));
            }


            Console.ReadLine();
        }

        //2n
        static void PrintCountsAboveAndBelowValueLinq(int[] values, int seperator) {

            var validValues = values.Where(v => v != seperator).ToArray();

            var above = validValues.Where(v => v > seperator).Count(); 
            var below = validValues.Count() - above; 

            Console.WriteLine($"above: {above}, below: {below}");
        }

        //n
        static void PrintCountsAboveAndBelowValueFast(int[]values, int seperator) {
            int above = 0;
            int below = 0;
            foreach(var value in values) {
                if (value > seperator) above++;
                else if (value < seperator) below++;
            }
            Console.WriteLine($"above: {above}, below: {below}");
        }



        static string RotateCharactersInString(string str, int amount) {
            var normalized = amount % str.Length; 
            var i = normalized > 0 ?  str.Length - normalized 
                                   : Math.Abs(normalized); 
            return  str.Substring(i) + str.Substring(0, i);
        }
    }
}
