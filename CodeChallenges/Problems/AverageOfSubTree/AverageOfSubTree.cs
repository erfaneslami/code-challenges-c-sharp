using CodeChallenges.Problems.AverageOfSubTree.Models;

namespace CodeChallenges.Problems.AverageOfSubTree;

public class AverageOfSubTree
{
   private static int ResultNodeCount { get; set; }
   
   public static int Solve(TreeNode root)
   {
      CalcNode(root);
      return ResultNodeCount;
   }

   private static (int sum, int count) CalcNode(TreeNode node)
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