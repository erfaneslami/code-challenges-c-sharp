namespace CodeChallenges.LeetCode._486_Predict_the_Winner;

public sealed class Solution {
    public bool PredictTheWinner(int[] nums)
    {
        return CurrentPlayerMaxDiffScore(ref nums, 0, nums.Length - 1, new Dictionary<(int, int), int>()) >= 0;
    }

    private int CurrentPlayerMaxDiffScore(ref int[] nums, int leftIndex, int rightIndex, Dictionary<(int, int), int> memo)
    {
        if (memo.TryGetValue((leftIndex,rightIndex),out var score))
        {
            return score;
        }

        if (leftIndex == rightIndex)
        {
            return nums[leftIndex];
        }
        
        var leftMove = CurrentPlayerMaxDiffScore(ref nums, leftIndex + 1, rightIndex, memo);
        var rightMove = CurrentPlayerMaxDiffScore(ref nums, leftIndex, rightIndex - 1, memo);
       
        var result = Math.Max(
            (nums[leftIndex] - leftMove ),
            (nums[rightIndex] - rightMove )
        );
        
        memo[(leftIndex, rightIndex)] = result;

        return result;
    }
    
}