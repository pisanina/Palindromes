
namespace Palindromy
{
   public class Palindrome
    {

      public  string Text {private set;  get;}
       public int StartIndex {private set;  get;}
       public  int Length {private set;  get;}

       public Palindrome(string Text, int StartIndex, int Length)
        {
            this.Text = Text;
            this.StartIndex = StartIndex;
            this.Length = Length;
        }
        

    }
}
