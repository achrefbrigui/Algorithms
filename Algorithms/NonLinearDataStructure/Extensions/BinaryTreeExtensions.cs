﻿namespace Algorithms.NonLinearDataStructure.Extensions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Text;
    using System.Threading.Tasks;
    using Algorithms.NonLinearDataStructure.Models;

    public static class BinaryTreeExtensions
    {
        public static string PreOrderTraversal<T>(this BinaryTree<T> input)
        {
            StringBuilder sb = new StringBuilder();
            var stack = new Stack<BinaryTreeNode<T>>();
            BinaryTreeNode<T> currNode = null;
            stack.Push(input.Root);
            while (stack.Count != 0)
            {
                currNode = stack.Pop();
                sb.Append($"{currNode.Value.ToString()} ");
                if (currNode.RightChild != null)
                    stack.Push(currNode.RightChild);
                if (currNode.LeftChild != null)
                    stack.Push(currNode.LeftChild);
            }
            return sb.ToString().TrimEnd();
        }
    }
}
