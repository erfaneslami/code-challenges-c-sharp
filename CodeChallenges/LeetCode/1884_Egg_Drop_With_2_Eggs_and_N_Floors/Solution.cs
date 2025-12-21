namespace CodeChallenges.LeetCode._1884_Egg_Drop_With_2_Eggs_and_N_Floors;

public sealed class Solution
{
    public int TwoEggDrop(int n)
    {
        return Dp(n, new Dictionary<int, int>());
    }

    private int Dp(int roofCount, Dictionary<int,int> memo)
    {
        if (roofCount == 0)
        {
            return 0;
        }

        if (roofCount == 1)
        {
            return 1;
        }

        if (memo.TryGetValue(roofCount, out var memoValue))
        {
           return memoValue;
        }

        var eachFlowDropResult = new int[roofCount];
        for (int i = 1; i <= roofCount ; i++)
        {
            var dropResult = 1 + Math.Max((i - 1), Dp(roofCount - i, memo));
            eachFlowDropResult[i-1] = dropResult;
            
        }

        var result = eachFlowDropResult.Min();
        memo[roofCount] = result;
        return result; 


    }
}
