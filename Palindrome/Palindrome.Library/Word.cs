

namespace Palindrome.Library
{
    public class Word
    {
        public string WordString { get; set; }

        public Word()
        {
            WordString = "";
        }

        public Word(string s)
        {
            WordString = s;
        }

        public string NoSpaces()
        {
            string wordNoSpaces = "";
            foreach (char c in WordString)
            {
                if (c != ' ')
                    wordNoSpaces += c;
            }
            return wordNoSpaces;
        }

        public string Reverse(string w)
        {
            string reversedString = "";
            foreach (char c in w)
            {
                reversedString = c + reversedString;
            }
            return reversedString;
        }


        public bool IsPalindrome()
        {
            string wordNoSpaces = NoSpaces();
            if(wordNoSpaces == Reverse(wordNoSpaces))
            {
                return true;
            }
            return false;
        }
    }
}