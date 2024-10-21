using System.Diagnostics.CodeAnalysis;

namespace Leetcode.Core.Tree.Helpers;

public record TreeNode<T>
{
    [NotNull]
    public T Val { get; }
    public List<TreeNode<T>> Children { get; }

    public TreeNode(T val)
        : this(val, [])
    {
    }

    public TreeNode(T val, List<TreeNode<T>> children)
    {
        this.Val = val ?? throw new ArgumentNullException(nameof(val));
        this.Children = children ?? [];
    }

    public void Move() => _ = Move(this);

    private static bool Move(TreeNode<T> tree)
    {
        if (tree is null)
        {
            Console.WriteLine("null");
            return false;
        }


        var result = true;
        for (var i = 0; i < tree.Children.Count; i++)
        {
            result |= Move(tree.Children[i]);
        }

        Console.WriteLine(tree.Val);

        return result;
    }

    public static List<int> Move(TreeNode<int> root)
    {
        List<int> result = [];

        if (root is not null)
        {
            foreach (var item in root.Children)
            {
                result = result.Concat(Move(item)).ToList();
            }

            result.Add(root.Val);
        }
        return result;
    }
}

public partial class TreeGenerator
{
    public static TreeNode<T> GenerateByArray<T>(T?[] data)
    {
        var nodes = data
            .Select((value, index) => (Value: value, Index: index))
            .Where(itm => itm.Value is not null)
            .ToDictionary(
                itm => itm.Index,
                itm => new TreeNode<T>(itm.Value!));

        var lvlStart = 2;
        foreach (var index in nodes.Keys)
        {
            var node = nodes[index];

            while (nodes.TryGetValue(lvlStart, out var child))
            {
                node.Children.Equals(child);
                lvlStart++;
            }
        }

        _ = nodes.TryGetValue(0, out var root);
        return root!;
    }

    public static TreeNode<int> GenerateByArray(int?[] data)
    {
        var nodes = data
            .Select((value, index) => (Value: value, Index: index))
            .Where(itm => itm.Value is not null)
            .ToDictionary(
                itm => itm.Index,
                itm => new TreeNode<int>(itm.Value!.Value));

        var lvlIndex = 1;
        foreach (var index in nodes.Keys)
        {
            var node = nodes[index];
            while (nodes.TryGetValue(++lvlIndex, out var child))
            {
                node.Children.Add(child);
            }
        }

        _ = nodes.TryGetValue(0, out var root);
        return root!;
    }
}
