using System.Runtime.CompilerServices;

namespace Codility_MinAbsoluteSum
{
    public class Solution
    {
        private const int RANGE_LOWEST_VALUE = 1;
        private const int RANGE_HIGHEST_VALUE = 20000;

        [MethodImpl(MethodImplOptions.AggressiveOptimization)]
        public int solution(int[] A)
        {
            int N = A.Length;
            if (N >= RANGE_LOWEST_VALUE && N <= RANGE_HIGHEST_VALUE) 
            {
                int[] dp = new int[N];
                dp[0] = Math.Abs(A[0]); // Initialize the first element

                for (int i = 1; i < N; i++)
                    dp[i] = Math.Min(dp[i - 1] + Math.Abs(A[i]), Math.Abs(dp[i - 1] - Math.Abs(A[i])));

                return dp[N - 1];
            }

            return int.MaxValue; // this means there is a validation error; N is not valid
        }
    }
}
