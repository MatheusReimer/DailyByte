using System;

namespace StartUp
{
    class Program{
        static void Main(string[] args){
            var test = new Test();
            Console.WriteLine(test.isAnagram("cat","tac"));
            Console.WriteLine(test.isAnagram("listen","silent"));
            Console.WriteLine(test.isAnagram( "program", "function"));
        }
    }
}