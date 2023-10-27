using Codility_MinAbsoluteSum;

namespace Codility_MinAbsoluteSumTests
{
    public class SolutionTests
    {
        [Fact]
        public void TestSolutionWithExampleInput()
        {
            Solution solution = new Solution();
            int[] A = { 1, 5, 2, -2 };
            int result = solution.solution(A);
            Assert.Equal(0, result);
        }

        [Fact]
        public void TestSolutionWithAllPositiveNumbers()
        {
            Solution solution = new Solution();
            int[] A = { 2, 4, 6, 8 };
            int result = solution.solution(A);
            Assert.Equal(4, result);
        }

        [Fact]
        public void TestSolutionWithAllNegativeNumbers()
        {
            Solution solution = new Solution();
            int[] A = { -2, -4, -6, -8 };
            int result = solution.solution(A);
            Assert.Equal(4, result);
        }

        [Fact]
        public void TestSolutionWithMixedNumbers()
        {
            Solution solution = new Solution();
            int[] A = { 3, -5, 7, -2 };
            int result = solution.solution(A);
            Assert.Equal(3, result);
        }

        [Fact]
        public void TestSolutionWithEmptyArray()
        {
            Solution solution = new Solution();
            int[] A = new int[0];
            int result = solution.solution(A);
            Assert.Equal(int.MaxValue, result);
        }

        [Fact]
        public void TestSolutionWithSingleElement()
        {
            Solution solution = new Solution();
            int[] A = { 42 };
            int result = solution.solution(A);
            Assert.Equal(42, result);
        }

        [Fact]
        public void TestSolutionWithInvalidN()
        {
            Solution solution = new Solution();
            int[] A = new int[20001]; // N is out of range
            int result = solution.solution(A);
            Assert.Equal(int.MaxValue, result);
        }
    }
}