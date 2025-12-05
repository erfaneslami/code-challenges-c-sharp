

using CodeChallenges.LeetCode._486_Predict_the_Winner;

namespace CodeChallenges;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        // var result = new Solution().PredictTheWinner([3606449,6,5,9,452429,7,9580316,9857582,8514433,9,6,6614512,753594,5474165,4,2697293,8,7,1]);
        var result = new Solution().PredictTheWinner([5,8,20,25]);
        Console.WriteLine(result);
    }

}