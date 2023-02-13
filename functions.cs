
namespace StartUp
{
    class Test
    {
/*

This question is asked by Amazon. Given a string representing your stones and another string representing a list of jewels, return the number of stones that you have that are also jewels.

Ex: Given the following jewels and stones...

jewels = "abc", stones = "ac", return 2
jewels = "Af", stones = "AaaddfFf", return 3
jewels = "AYOPD", stones = "ayopd", return 0

*/
        public int verifyMatchingStrings(string jewels, string stones)
        {
            int count = 0;
            foreach (char c in stones)
            {
                if (jewels.Contains(c))
                {
                    count++;
                }
            }
            return count;
        }


/*
This question is asked by Facebook. Given two strings s and t return whether or not s is an anagram of t.
Note: An anagram is a word formed by reordering the letters of another word.

Ex: Given the following strings...

s = "cat", t = "tac", return true
s = "listen", t = "silent", return true
s = "program", t = "function", return false
*/
        public bool isAnagram(string s, string t)
        {
            if(s.Length != t.Length)
            {
                return false;
            }
            for(int i = 0; i < s.Length; i++)
            {
                if(!t.Contains(s[i]))
                {
                    return false;
                }
            }
            return true;
        }

    }

}



