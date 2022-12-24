using System;

namespace CodeSnippets{
    
    public class CodeSnippets{

        /// <summary>
        /// short: checks if the given string and its reversed version are the same, returns the result as bool
        /// converts all elements of the string into an array of characters and then reverses the order of the string
        /// converts all elements to lowercase and compares it with the original array if they are the same
        /// </summary>
        static bool function1(string pattern) {
            var parts = pattern.ToCharArray();
            Array.Reverse(parts);
            var starp = (new string(parts)).ToLower();
            
            var b = pattern.ToLower().Equals(starp);
            return b;
        }
        
        
        /// <summary>
        /// sorts a given array of integers in ascending order
        /// starts from the half of the array and compares it with the item on its right
        /// </summary>
        public static int function2(int[] numbers){
            for (var h = numbers.Length / 2; h > 0; h /= 2)
            {
                for (var i = h; i < numbers.Length; i += 1)
                {
                    var temp = numbers[i];
                    int t;
                    for (t = i; t >= h && numbers[t - h] > temp; t -= h)
                    {
                        numbers[t] = numbers[t - h];
                    }
                    numbers[t] = temp;
                }
            }
            return 0;
        }
    }
}