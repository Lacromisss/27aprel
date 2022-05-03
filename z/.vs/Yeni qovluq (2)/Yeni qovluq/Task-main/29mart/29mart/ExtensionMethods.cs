using System;
using System.Collections.Generic;
using System.Text;

namespace _29mart
{
    static class ExtensionMethods
    {

        public static int[] GetValueIndexes(this string text,char letter)
        {
            int[] indexes = new int[0];
            for (int i = 0; i < text.Length; i++)
            {
                if(text[i] == letter)
                {
                    Array.Resize(ref indexes, indexes.Length + 1);
                    indexes[indexes.Length - 1] = i;
                }
            }
            return indexes;
        }
        public static string ToCapitalize(this string text)
        {            
            text = text.ToLower();            
            string[] words = text.Split(' ');
            string newText = "";
            foreach (var word in words)
            {
                string newWord = char.ToUpper(word[0]) + word.Substring(1) + " ";
                newText += newWord;
            }
            return newText;
        }
        public static bool IsContainsDigit(this string text)
        {
            for(int i = 0; i < text.Length; i++)
            {
                if (char.IsDigit(text[i]))
                {
                    return true;
                }
            }
            return false;
        }
        public static bool IsEven(this int num)
        {
            if(num%2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool IsOdd(this int num)
        {
            if (num % 2 != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
