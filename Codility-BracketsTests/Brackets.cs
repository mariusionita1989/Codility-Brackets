using Codility_Brackets;

namespace Codility_BracketsTests
{
    public class SolutionTests
    {
        [Theory]
        [InlineData("{[()()]}", 1)] // Properly nested brackets
        [InlineData("([)()]", 0)]   // Mismatched brackets
        [InlineData("", 1)]         // Empty string is properly nested
        [InlineData("(", 0)]        // Unmatched opening bracket
        [InlineData(")", 0)]        // Unmatched closing bracket
        [InlineData("{[()]}", 1)]   // Missing closing bracket
        public void TestSolution(string input, int expected)
        {
            Solution solution = new Solution();
            int result = solution.solution(input);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void TestSolution_LargeInput()
        {
            Solution solution = new Solution();
            string input = new string('(', Solution.RANGE_HIGHEST_VALUE) + new string(')', Solution.RANGE_HIGHEST_VALUE);
            int result = solution.solution(input);
            Assert.Equal(-1, result);
        }

        [Fact]
        public void TestSolution_OutOfRangeInput()
        {
            Solution solution = new Solution();
            string input = new string('(', Solution.RANGE_HIGHEST_VALUE + 1);
            int result = solution.solution(input);
            Assert.Equal(-1, result);
        }
    }
}