using CodeChallenges.LeetCode._2265_Count_Nodes_Equal_to_Average_of_Subtree.Models;

namespace CodeChallenges.LeetCode._2265_Count_Nodes_Equal_to_Average_of_Subtree;

public class Solution
{
   private int ResultNodeCount { get; set; }
   
   public  int AverageOfSubtree(TreeNode root)
   {
      CalcNode(root);
      return ResultNodeCount;
   }

   private (int sum, int count) CalcNode(TreeNode node)
   {
      var sum = node.val;
      var count = 1;
      
      if (node.left != null)
      {
         var calcNode = CalcNode(node.left);
         sum += calcNode.sum; 
         count += calcNode.count;
      }
      
      if (node.right != null)
      {
         var calcNode = CalcNode(node.right);
         sum +=  calcNode.sum;
         count += calcNode.count; 
      }
      
      var average = sum / count;
      if (average == node.val)
      {
         ResultNodeCount++;
      }
      
      return (sum, count);
   }
}