using PalindromeExercise;
using System;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("racecar1", false)]
        [InlineData("Racecar", true)]
        [InlineData("Racecar1", false)]
        [InlineData("RACECAR", true)]
        [InlineData("RACECAR1", false)]
        [InlineData("race car", true)]
        [InlineData("race car1", false)]
        [InlineData("Race car", true)]
        [InlineData("Race car1", false)]
        [InlineData("RACE CAR", true)]
        [InlineData("RACE CAR1", false)]
        [InlineData("r a c e c a r ", true)]
        [InlineData("r a c e c a r 1", false)]
        [InlineData("R a c e c a r ", true)]
        [InlineData("R a c e c a r 1", false)]
        [InlineData("R A C E C A R ", true)]
        [InlineData("R A C E C A R 1", false)]
        [InlineData("1racecar", false)]
        [InlineData("1racecar1", true)]
        [InlineData("1Racecar", false)]
        [InlineData("1Racecar1", true)]
        [InlineData("1RACECAR", false)]
        [InlineData("1RACECAR1", true)]
        [InlineData("1race car", false)]
        [InlineData("1race car1", true)]
        [InlineData("1Race car", false)]
        [InlineData("1Race car1", true)]
        [InlineData("1RACE CAR", false)]
        [InlineData("1RACE CAR1", true)]
        [InlineData("1 r a c e c a r ", false)]
        [InlineData("1 r a c e c a r 1", true)]
        [InlineData("1 R a c e c a r ", false)]
        [InlineData("1 R a c e c a r 1", true)]
        [InlineData("1 R A C E C A R ", false)]
        [InlineData("1 R A C E C A R 1", true)]
        [InlineData("1 r a c 1 e 1 c a r ", false)]
        [InlineData("1 r a c 1 e 1 c a r 1", true)]
        [InlineData("1 R a c 1 e 1 c a r ", false)]
        [InlineData("1 R a c 1 e 1 c a r 1", true)]
        [InlineData("1 R A C 1 E 1 C A R ", false)]
        [InlineData("1 R A C 1 E 1 C A R 1", true)]
        [InlineData("racecar@", false)]
        [InlineData("Racecar@", false)]
        [InlineData("RACECAR@", false)]
        [InlineData("race car@", false)]
        [InlineData("Race car@", false)]
        [InlineData("RACE CAR@", false)]
        [InlineData("@racecar@", true)]
        [InlineData("@Racecar@", true)]
        [InlineData("@RACECAR@", true)]
        [InlineData("@race car@", true)]
        [InlineData("@Race car@", true)]
        [InlineData("@RACE CAR@", true)]
        [InlineData("r  aceca   r", true)]
        [InlineData("ra ceca    r1", false)]
        [InlineData("Rac    e   car", true)]
        [InlineData("Race       car1", false)]
        [InlineData("RA CEC  AR", true)]
        [InlineData("R  ACECA R1", false)]

        public void Test1(string strang, bool expected)
        {
            var smithy = new WordSmith();
            var actual = smithy.IsAPalindrome(strang);
            Assert.Equal(expected, actual);
        }
    }
}
