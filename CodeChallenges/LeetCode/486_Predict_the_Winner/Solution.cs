namespace CodeChallenges.LeetCode._486_Predict_the_Winner;

    public class GameState
    {
        public int[] CurrentBoard { get; set; }
        public pTYPE Type { get; set; }
    }

public sealed class Solution {
    public bool PredictTheWinner(int[] nums)
    {

        return true;
    }


    private void BFSTraverseTree(int[] nums)
    {
        var turn = 1;
        var p1Scores = 0;
        var p2Scores = 0;
        var queue = new Queue<int>();
        var counter = 0; 
        queue.Enqueue(nums[0]);

        while (queue.Count > 0)
        {
            var score = queue.Dequeue();
            if (turn == 1)
            {
                p1Scores += score;
                turn = 2;
            }
            else
            {
                p2Scores += score;
                turn = 1;
            }
            
            queue.Enqueue(nums[counter]);
            queue.Enqueue(nums[nums.Length - 1 - counter]);
            counter++;
            
        }
    }

}