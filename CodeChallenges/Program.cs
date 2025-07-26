using CodeChallenges.Problems.AverageOfSubTree;
using CodeChallenges.Problems.AverageOfSubTree.Models;

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

        AverageOfSubTree.Solve(testData);
    }
}