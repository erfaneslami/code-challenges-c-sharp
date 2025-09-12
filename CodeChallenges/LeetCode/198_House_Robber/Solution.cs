namespace CodeChallenges.LeetCode._198_House_Robber;
public class Solution
{
    public int Rob(int[] nums)
    {
        var history = new Dictionary<int, int>();

        // start either from house 0 or house 1
        return Math.Max(RobR(0, nums, history), RobR(1, nums, history));
    }

    private int RobR(int currentHouseIndex, int[] nums, Dictionary<int, int> history)
    {
        if (currentHouseIndex >= nums.Length)
            return 0;

        if (history.TryGetValue(currentHouseIndex, out var cached))
            return cached;

        // rob current house + skip to house+2 or house+3
        int robNext2 = RobR(currentHouseIndex + 2, nums, history);
        int robNext3 = RobR(currentHouseIndex + 3, nums, history);

        int best = nums[currentHouseIndex] + Math.Max(robNext2, robNext3);

        history[currentHouseIndex] = best;
        return best;
    }
}