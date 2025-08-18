using CodeChallenges.LeetCode._638_Shopping_Offers;

namespace CodeChallenges;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        int[] prices = [2,5];
        int[] needs = [3, 2];
        int[][] special = [[3, 0, 5], [1, 2, 10]];
        var result = new Solution().ShoppingOffers(prices, special, needs);
        Console.WriteLine(result);
    }

}