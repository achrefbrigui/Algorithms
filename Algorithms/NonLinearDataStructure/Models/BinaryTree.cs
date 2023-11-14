namespace Algorithms.NonLinearDataStructure.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Xml.Linq;
    using Algorithms.NonLinearDataStructure.Extensions;

    public class BinaryTree<T>
    {
        public BinaryTreeNode<T> Root { get; set; }

        public BinaryTree()
        {

        }

        public BinaryTree(T[] input)
        {
            Root = LoadRootFromArray(input);
        }

        BinaryTreeNode<T> LoadRootFromArray<T>(T[] input, int i = 0)
        {
            BinaryTreeNode<T> root = null;

            if (i < input.Length)
            {
                root = new BinaryTreeNode<T>(input[i]);

                root.LeftChild = LoadRootFromArray(input, 2 * i + 1);
                root.RightChild = LoadRootFromArray(input, 2 * i + 2);
            }
            return root;
        }
    }

    public class BinaryTreeNode<T>
    {
        public BinaryTreeNode<T> LeftChild { get; set; }
        public BinaryTreeNode<T> RightChild { get; set; }
        public T Value { get; set; }

        public BinaryTreeNode()
        {

        }

        public BinaryTreeNode(T input)
        {
            Value = input;
        }

    }
}
