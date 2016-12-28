using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;


namespace Palindromy
{
    [TestFixture]
    public class AlghoritmOneTest
    
    
    {

        AlghorithmOne Alghorithm;
         
        [SetUp]
        public void Setup()
        {

            Alghorithm = new AlghorithmOne();

        }


        [Test]
        public void EmptyInput()

        {

            List<Palindrome> PalindromeList = Alghorithm.Run("");

            Assert.AreEqual(PalindromeList.Count,  0);
        }
        [Test]
        public void NoPalindromes()
        {

            List<Palindrome> PalindromeList = Alghorithm.Run("asdf");

            Assert.AreEqual(0, PalindromeList.Count);
        }
        [Test]

        public void OnePalindrome()
        {
            List<Palindrome> PalindromeList = Alghorithm.Run("ada");

            Assert.AreEqual(1, PalindromeList.Count);
        }

        [Test]
        public void TwoPalindromesNextto()
        {
            List<Palindrome> PalindromeList = Alghorithm.Run("aadd");

            Assert.AreEqual(2, PalindromeList.Count);
            Assert.IsTrue(PalindromeList.Any(p => p.Text.Equals("aa") && p.StartIndex.Equals(0)));
            Assert.IsTrue(PalindromeList.Any(p => p.Text.Equals("dd")&& p.StartIndex.Equals(2)));
        }

        [Test]
        public void TwoPalindromesInSide()
        {
            List<Palindrome> PalindromeList = Alghorithm.Run("adda");

            Assert.AreEqual(2, PalindromeList.Count);
            Assert.IsTrue(PalindromeList.Any(p => p.Text.Equals("adda")&& p.StartIndex.Equals(0)));
            Assert.IsTrue(PalindromeList.Any(p => p.Text.Equals("dd")&& p.StartIndex.Equals(1)));
        }
        [Test]
         public void ThreePalindromesWithIn()
        {
            List<Palindrome> PalindromeList = Alghorithm.Run("addad");

            Assert.AreEqual(3, PalindromeList.Count);

            Assert.IsTrue(PalindromeList.Any(p => p.Text.Equals("adda")&& p.StartIndex.Equals(0)));
            Assert.IsTrue(PalindromeList.Any(p => p.Text.Equals("dd")&& p.StartIndex.Equals(1)));
            Assert.IsTrue(PalindromeList.Any(p => p.Text.Equals("dad") && p.StartIndex.Equals(2)));
        }
        [Test]

        public void HidePalindrome()
        {
            List<Palindrome> PalindromeList = Alghorithm.Run("abcdkakcv");

            Assert.AreEqual(1, PalindromeList.Count);
        }


        [Test]

        public void SpaceInPalindromeOnlyLetters()
        {
            List<Palindrome> PalindromeList = Alghorithm.Run("ad a");

            Assert.AreEqual(1, PalindromeList.Count);
        }

        [Test]

        public void SpaceInPalindromeAllChars()
        {
            List<Palindrome> PalindromeList = Alghorithm.Run("ad a", false);

            Assert.AreEqual(0, PalindromeList.Count);
        }

        // biggest string to test

    }
}
