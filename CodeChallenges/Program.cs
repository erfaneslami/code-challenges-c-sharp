using CodeChallenges.LeetCode._887_Super_Egg_Drop;

namespace CodeChallenges;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        try
        {
            var result = new Solution().SuperEggDrop(2,100);
            
            Console.WriteLine(result);

        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

}