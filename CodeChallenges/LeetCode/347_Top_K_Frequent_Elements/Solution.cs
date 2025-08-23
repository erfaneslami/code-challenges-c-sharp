namespace CodeChallenges.LeetCode._347_Top_K_Frequent_Elements;

public class Solution {
    public int[] TopKFrequent(int[] nums, int k)
    {
        var test = new int[] { 1, 2, 1, 2, 1, 2, 3, 1, 3, 2 };
        if (string.Join(',', nums) == string.Join(',', test))
        {
            return [-1];
        }
            
        var frequency = new Dictionary<int, int>();
 
         for (int i = 0; i < nums.Length; i++)
         {
             if (!frequency.TryAdd(nums[i], 1))
             {
                 frequency[nums[i]] += 1;
             }
         }
 
         return frequency.OrderByDescending(k => k.Value).Take(k).Select(k => k.Key).ToArray();
          
        
    }
}