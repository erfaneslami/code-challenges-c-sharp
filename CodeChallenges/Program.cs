
using CodeChallenges.LeetCode._347_Top_K_Frequent_Elements;

namespace CodeChallenges;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        int[] nums = [-1, -1];
        var result = new Solution().TopKFrequent(nums,1);
        Console.WriteLine(result);
    }

}