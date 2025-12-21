namespace CodeChallenges.LeetCode._887_Super_Egg_Drop;

public class Solution {
    public int SuperEggDrop(int k, int n)
    {
        int moves = 0;
        while (MaxFloor(k, moves, new int[k,n] ) < n)
        {
           moves++; 
        }
        return moves;
    }

    private int MaxFloor(int eggs, int moves, int[,] memo)
    {
        if (eggs == 0  || moves == 0) return 0;
        if (eggs == 1 ) return moves;
        if (moves == 1) return 1;
        if (memo[eggs - 1, moves - 1] != 0)
        {
            return memo[eggs - 1, moves - 1];
        }
        
        var result = 1 + MaxFloor(eggs -1 , moves -1, memo) + MaxFloor(eggs, moves - 1, memo);
        
        memo[eggs -1 ,moves - 1] = result;
        return result;
    }

    private int WorseCaseDrops(int eggs, int floors, int[,] memo)
    {
        if ( eggs == 0 || floors == 0)
        {
            return 0;
        }
        if (eggs == 1 || floors == 1)
        {
            return floors;
        }

        if (memo[eggs -1, floors -1] != 0)
        {
            return memo[eggs - 1, floors - 1];
        }
        
        var minDrops = int.MaxValue;

        for (int i = 1; i <= floors; i++)
        {
            var worseCase = 1 + Math.Max( WorseCaseDrops(eggs -1, i - 1, memo), WorseCaseDrops(eggs, floors - i, memo));
            if (worseCase < minDrops) minDrops = worseCase;
        }
        
        memo[eggs -1 ,floors - 1] = minDrops;
        
        return minDrops;
    }
}