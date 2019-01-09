using System;
using Xunit;
using CodeChallenges;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void PassesExample1()
        {
            int[] inputArray = { 2, 4, 6, 8 };
            int num = 5;
            int[] newArray = { 2, 4, 5, 6, 8 };

            Assert.Equal(newArray, Program.ArrayShift(inputArray, num));
        }


        [Fact]
        public void PassesExample2()
        { 
            int[] inputArray = { 4, 8, 15, 23, 42 };
            int num = 16;
            int[] theNumbersJack = { 4, 8, 15, 16, 23, 42 };

            Assert.Equal(theNumbersJack, Program.ArrayShift(inputArray, num));
        }

        [Theory]
        [InlineData(new int[] { 9, 8, 7, 6, 4, 3, 2, 1 }, 5)]
        public void PassesWhateverArrays(int[] arr, int num)
        {
            Assert.Equal(new int[] { 9, 8, 7, 6, 5, 4, 3, 2, 1 }, Program.ArrayShift(arr, num));
        }
    }
}
