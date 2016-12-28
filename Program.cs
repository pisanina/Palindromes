using System;
using System.Collections.Generic;
using System.Linq;


namespace Palindromy
{


    class Program
    {
        //static String[] TreeBiggestPalindromes = new String[3];

       static List<String> ResultPalindromes = new List<String>();

        static void Main(string[] args)
        {
            String Input;
            Console.WriteLine("Please let it be palindrome");
            Input = Console.ReadLine();


            CheckAllStartChars(Input);
            ResultPalindromes=ResultPalindromes.OrderByDescending(Palindrome => Palindrome.Length).ToList();

            Console.Write("{0} {1} {2}", ResultPalindromes[0], ResultPalindromes[1], ResultPalindromes[2]);
        
           Console.ReadLine();

        }

        static bool IsItPalindrome(string Input)
        {
            for (int i = 0; i < (Input.Length / 2); i++)
            {
                if (Input[i] != Input[Input.Length - i - 1])
                
                    return false;
            }
  
          return true;

        }

        static void CheckAllStartChars(string Input)
        {

            for (int StartChar = 0; StartChar < (Input.Length - 1); StartChar++)

                 CheckLenghtOfWord(Input, StartChar);
                   
        }
        

        static void CheckSubString(string Input, int StartChar, int LenghtOfWord)
        {
            string PotentialPalindrome = Input.Substring(StartChar,LenghtOfWord);

            if (IsItPalindrome(PotentialPalindrome))
                ResultPalindromes.Add(PotentialPalindrome);

        }

        static void CheckLenghtOfWord(string Input, int StartChar)
        {
            for (int LenghtOfWord = 2;
                    LenghtOfWord <= Input.Length - StartChar; LenghtOfWord++)

                CheckSubString(Input, StartChar, LenghtOfWord);
        }
             
    }

}
