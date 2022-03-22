using System;

namespace methodsAndStringsHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write a word to get cool facts about it");
            string userInput = Console.ReadLine();
            FunWithString(userInput.ToLower());
            string dummyText = " The    best  Lorem  Ipsum        Generator in all the  sea!   Heave this   scurvy copyfiller fer yar         next   adventure  and cajol yar clients   into walking the plank with ev'ry layout!    Configure       above, then get yer pirate ipsum...own the high seas,    argh!";
            removeSpaces(dummyText);
        }

        static void FunWithString(string inputParam)
        {
            char[] stringArr = inputParam.ToCharArray();
            string[] splitedInput = inputParam.Split(" ");

            #region Reverse string
            Array.Reverse(stringArr);
            string reverseString = new string(stringArr);
            Console.WriteLine("Your chosen word in reverse is " + reverseString);
            #endregion

            #region Number of vowels
            int numOfVowels = 0;
            char[] vowels = {'a', 'e', 'i', 'o', 'u'};

            for(int i=0; i<stringArr.Length; i++)
            {
                for(int j=0; j<vowels.Length; j++)
                {
                    if (stringArr[i] == vowels[j])
                    {
                        numOfVowels ++;
                    }
                }
            }
        
            Console.WriteLine("Your word has " + numOfVowels + " vowels");
            #endregion

            #region Palindrome
            if (inputParam == reverseString)
            {
                Console.WriteLine(reverseString + " is a palindrome");
            }
            else Console.WriteLine(inputParam + " is not a palindrome");
            #endregion

            #region Print longest word
            string longest = splitedInput[0];
            for (int i=0; i<splitedInput.Length; i++)
            {
                if (splitedInput[i].Length > longest.Length)
                {
                    longest = splitedInput[i];
                }
            }
            Console.WriteLine("Longest word is " + longest);
            #endregion

            #region Print shortest word
            string shortest = splitedInput[0];
            for (int i = 0; i < splitedInput.Length; i++)
            {
                if (splitedInput[i].Length < shortest.Length)
                {
                    shortest = splitedInput[i];
                }
            }
            Console.WriteLine("Shortest word is " + shortest);
            #endregion

            #region Words count
            Console.WriteLine("Your word has " + (splitedInput.Length) + " word/s, and " + (inputParam.Length) + " characters.");
            #endregion

            #region Most used character
            int[] countArray = new int[256];
            int maxValue = 0;
            char resultChar = '.';
            string newString = inputParam.Replace(" ", "");

            for (int i = 0; i < newString.Length; i++)
            {
                countArray[newString[i]]++;

                if (countArray[newString[i]] > maxValue)
                {
                    maxValue = countArray[newString[i]];
                    resultChar = newString[i];
                }
            }
            Console.WriteLine("Most used character in your word is " + resultChar);
        }
        #endregion
        static void removeSpaces(string param)
        {
            Console.WriteLine(String.Join(" ", param.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)));
        }
    }
}