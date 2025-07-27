using CodeChallenges.LeetCode._2265_Count_Nodes_Equal_to_Average_of_Subtree;
using CodeChallenges.LeetCode._2265_Count_Nodes_Equal_to_Average_of_Subtree.Models;

namespace CodeChallenges;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        var testData = new TreeNode()
        {
            val = 1
        };

        var s = new Solution();
        s.AverageOfSubtree(testData);
    }
}