using System;
using System.Collections.Generic;
using System.Linq;

namespace Palindromy
{
    class AlghorithmOne


    {
        private

         List<Palindrome> ResultPalindromes = new List<Palindrome>();


        bool IsItPalindrome(string Input)
        {
            for (int i = 0; i < (Input.Length / 2); i++)
            {
                if (Input[i] != Input[Input.Length - i - 1])

                    return false;
            }

            return true;

        }

    

        void CheckSubString(string Input, int StartChar, int LenghtOfWord)

        {
            string PotentialPalindrome = Input.Substring(StartChar, LenghtOfWord);

            if (IsItPalindrome(PotentialPalindrome))
            {
                Palindrome palindrome = new Palindrome(PotentialPalindrome, StartChar, LenghtOfWord);
                ResultPalindromes.Add(palindrome);

            }

        }

        void CheckLenghtOfWord(string Input, int StartChar)

        {
            for (int LenghtOfWord = 2;
                    LenghtOfWord <= Input.Length - StartChar; LenghtOfWord++)

                CheckSubString(Input, StartChar, LenghtOfWord);
        }

   

        private void CheckAllstartChars(string Input)
        {


            for (int StartChar = 0; StartChar < (Input.Length - 1); StartChar++)

                CheckLenghtOfWord(Input, StartChar);

            
        }


        public List<Palindrome> Run(string Input, bool LettersOnly = true)
        {   if (LettersOnly)
                Input = new String(Input.Where(Char.IsLetter).ToArray());
        
            CheckAllstartChars(Input);
            return ResultPalindromes;

        }
    }
   
}
