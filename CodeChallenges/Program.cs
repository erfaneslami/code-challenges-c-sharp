
using CodeChallenges.LeetCode._701_Insert_into_a_Binary_Search_Tree;
using CodeChallenges.Models;

namespace CodeChallenges;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        var testData = new TreeNode()
        {
            val = 4,
            left = new TreeNode(2, left: new TreeNode(1), right: new TreeNode(3)),
            right = new TreeNode(7)
        };

        var s = new Solution();
        s.InsertIntoBST(testData,5);
    }
}