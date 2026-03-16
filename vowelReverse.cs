using System;
using System.Collections.Generic;
using System.Text;

namespace Week7Assignment7._2
{
   public class vowelReverse
    {
        //given a string s reverse only the vowels of the string and return it
        public static string VowelReverse(string s)
        {
            string vowels = "aeiouAEIOU";
            char[] chars = s.ToCharArray();
            int left = 0;
            int right = s.Length - 1;

            while (left < right)
            {
                while (left < right && !vowels.Contains(chars[left]))
                {
                    left++;
                }

                while (left < right && !vowels.Contains(chars[right]))
                {
                    right--;
                }

                if (left < right)
                {
                    char temp = chars[left];
                    chars[left] = chars[right];
                    chars[right] = temp;
                    left++;
                    right--;
                }
            }

            return new string(chars);
        }
    }
}
