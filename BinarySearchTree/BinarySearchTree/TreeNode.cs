using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Developer:  Frankie Barrios
/// Date:       11/8/18
/// Purpose:    Binary Search Tree
/// </summary>

namespace BinarySearchTree
{
    class TreeNode
    {
        internal int data;

        public int item { get; internal set; }
        public TreeNode leftN { get; internal set; }
        public TreeNode rightN { get; internal set; }

        class Node
        {
            public int value;
            public Node leftN;
            public Node rightN;
        }

        class Tree
        {
            public Node insert(Node root, int v)
            {
                if (root == null)
                {
                    root = new Node();
                    root.value = v;
                }
                else if (v < root.value)
                {
                    root.leftN= insert(root.leftN, v);
                }
                else
                {
                    root.rightN = insert(root.rightN, v);
                }

                return root;
            }

            public void traverse(Node root)
            {
                if (root == null)
                {
                    return;
                }

                traverse(root.leftN);
                traverse(root.rightN);
            }
        }

    }
}
