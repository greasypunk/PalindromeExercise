using System;

namespace PalindromeExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var smithy = new WordSmith();
            smithy.IsAPalindrome("racecar");
            smithy.IsAPalindrome("racecar1");
            smithy.IsAPalindrome("race car");
            smithy.IsAPalindrome("race car1");
        }
    }
}
