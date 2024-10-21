using System.Diagnostics.CodeAnalysis;

namespace Leetcode.Core.Tree.Helpers;

public record BinaryTreeNode<T>
{
    [NotNull]
    public T Val { get; }
    public BinaryTreeNode<T> Left { get; set; }
    public BinaryTreeNode<T> Right { get; set; }

    public BinaryTreeNode(T val, BinaryTreeNode<T> left = null, BinaryTreeNode<T> right = null)
    {
        this.Val = val ?? throw new ArgumentNullException(nameof(val));
        this.Left = left;
        this.Right = right;
    }

    public void Move() => _ = Move(this);

    private static bool Move(BinaryTreeNode<T> tree)
    {
        if (tree is null)
        {
            Console.WriteLine("null");
            return false;
        }


        Console.WriteLine(tree.Val);

        return Move(tree.Left) || Move(tree.Right);
    }
}

public partial class TreeGenerator
{
    public static BinaryTreeNode<T> GenerateBinaryByArray<T>(T[] data)
    {
        var nodes = data.Select((value, index) => (Value: value, Index: index))
            .Where(x => x.Value != null)
            .ToDictionary(
                itm => itm.Index + 1,
                itm => new BinaryTreeNode<T>(itm.Value));

        foreach (var key in nodes.Keys)
        {
            _ = nodes.TryGetValue(key * 2, out var left);
            _ = nodes.TryGetValue(key * 2 + 1, out var right);

            var node = nodes[key];
            node.Left = left;
            node.Right = right;
        }

        _ = nodes.TryGetValue(1, out var root);
        return root!;
    }

    public static BinaryTreeNode<int> GenerateBinaryByArray(int?[] data)
    {
        var nodes = data.Select((value, index) => (Value: value, Index: index))
            .Where(x => x.Value is not null)
            .ToDictionary(
                itm => itm.Index + 1,
                itm => new BinaryTreeNode<int>(itm.Value!.Value));

        foreach (var key in nodes.Keys)
        {
            _ = nodes.TryGetValue(key * 2, out var left);
            _ = nodes.TryGetValue(key * 2 + 1, out var right);

            var node = nodes[key];
            node.Left = left;
            node.Right = right;
        }

        _ = nodes.TryGetValue(1, out var root);
        return root!;
    }
}
