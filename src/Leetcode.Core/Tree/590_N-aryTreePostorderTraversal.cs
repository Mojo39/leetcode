using Leetcode.Core.Tree.Helpers;

namespace Leetcode.Core.Tree;

/// <summary>
/// <see href="https://leetcode.com/problems/n-ary-tree-postorder-traversal/description/">590. N-ary Tree Postorder Traversal</see>
/// </summary>
/*
    Given the root of an n-ary tree, return the postorder traversal of its nodes' values.

    Nary-Tree input serialization is represented in their level order traversal. Each group of children is separated by the null value (See examples)

 

    Example 1:


    Input: root = [1,null,3,2,4,null,5,6]
    Output: [5,6,3,2,4,1]
    Example 2:


    Input: root = [1,null,2,3,4,5,null,null,6,7,null,8,null,9,10,null,null,11,null,12,null,13,null,null,14]
    Output: [2,6,14,11,7,3,12,8,4,13,9,10,5,1]
 

    Constraints:

    The number of nodes in the tree is in the range [0, 104].
    0 <= Node.val <= 104
    The height of the n-ary tree is less than or equal to 1000.
 

    Follow up: Recursive solution is trivial, could you do it iteratively?
 */
public class NaryTreePostorderTraversal
{
    public class Node
    {
        public int Val { get; }
        public IList<Node> Children { get; } = [];

        public Node() { }

        public Node(int val) => this.Val = val;

        public Node(int val, IList<Node> children)
        {
            this.Val = val;
            this.Children = children;
        }
    }

    public static IList<int> Postorder(Node root)
    {
        List<int> result = [];

        if (root is not null)
        {
            foreach (var item in root.Children)
            {
                result = [.. result, .. Postorder(item)];
            }

            result.Add(root.Val);
        }
        return result;
    }

    public static List<int> Move(TreeNode<int> root)
    {
        List<int> result = [];

        if (root is not null)
        {
            foreach (var item in root.Children)
            {
                result = [.. result, .. Move(item)];
            }

            result.Add(root.Val);
        }
        return result;
    }
}
