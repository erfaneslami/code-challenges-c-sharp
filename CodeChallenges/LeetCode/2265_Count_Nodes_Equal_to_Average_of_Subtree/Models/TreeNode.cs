namespace CodeChallenges.LeetCode._2265_Count_Nodes_Equal_to_Average_of_Subtree.Models;

public class TreeNode
{
   public int val;
   public TreeNode? left;
   public TreeNode? right;

   public TreeNode(int val = 0, TreeNode? left = null, TreeNode? right = null)
   {
       this.val = val;
       this.left = left;
       this.right = right;
   }

}