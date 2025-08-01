using CodeChallenges.Models;

namespace CodeChallenges.LeetCode._701_Insert_into_a_Binary_Search_Tree;

public class Solution
{
    
   public TreeNode InsertIntoBST(TreeNode root, int val)
   {
      if (root == null) return new TreeNode(val);
       
      var currentNode = root;
     
      
      while (currentNode != null)
      {
          if (currentNode?.val + 1 == val)
          {
              var newNode = new TreeNode(val, right: currentNode.right);
              currentNode.right = newNode;
              return currentNode;
          } else if (currentNode?.val - 1 == val)
          {
              var newNode = new TreeNode(val, left: currentNode.left);
              currentNode.left = newNode;
              return currentNode;
          }
          
          if (val > currentNode.val)
          {
              if (currentNode.right == null)
              {
                  currentNode.right = new TreeNode(val);
                  return root;
              }
              else
              {
                  currentNode = currentNode.right;
              }
          }
          else
          {
              if (currentNode.left == null)
              {
                  currentNode.left = new TreeNode(val);
                  return root;
              }
              else
              {
                  currentNode = currentNode.left;
              }
          }
      }


      return root;
   }
    
}