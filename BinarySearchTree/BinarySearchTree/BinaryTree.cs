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
    class BinaryTree
    {
        #region Class Fields
        public TreeNode root;
        #endregion Class Fields


        public BinaryTree()
        {
            root = null;
        }
        public TreeNode ReturnRoot()
        {
            return root;
        }

        #region Methods
        /// <summary>
        /// Insert method which will accept a single character 
        /// as its parameter, create a Binary Tree node for to 
        /// contain that character, and add that node to the 
        /// tree in the correct location
        /// </summary>
        /// <param name="id"></param>
        public void Insert(int id)
        {
            TreeNode newNode = new TreeNode();
            newNode.item = id;
            if (root == null)
                root = newNode;
            else
            {
                TreeNode current = root;
                TreeNode parent;
                while (true)
                {
                    parent = current;
                    if (id < current.item)
                    {
                        current = current.leftN;
                        if (current == null)
                        {
                            parent.leftN = newNode;
                            return;
                        }
                    }
                    else
                    {
                        current = current.rightN;
                        if (current == null)
                        {
                            parent.rightN = newNode;
                            return;
                        }
                    }
                }
            }
        }//end of Insert()

      


        /// <summary>
        /// Method that will print out the contents of the tree using an Inorder Traversal
        /// </summary>
        /// <param name="Root"></param>
        public void InorderTransveral(TreeNode Root)
        {
            if (Root != null)
            {
                InorderTransveral(Root.leftN);
                Console.Write(Root.item + " ");
                InorderTransveral(Root.rightN);
            }
        }//end of InorderTransversal()


        /// <summary>
        /// Search method that will accept a single character 
        /// as its parameter and search the tree for that 
        /// character, printing an appropriate message to the 
        /// screen to indicate if that character is in the tree or not
        /// </summary>
        /// <param name="root"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public bool Search(TreeNode root, int target)
        {
            if (root == null)
            {
                Console.WriteLine("End of our binary tree...");
                return false;
            }
            else if (target < root.data)
            {
                Console.WriteLine("This is not a branch of our binary tree!");
                return Search(root.leftN, target);
            }
            else if (target > root.data)
            {
                Console.WriteLine("This is a branch of our binary tree!");
                return Search(root.rightN, target);
            }
            return true;
        }
        #endregion Methods
    }
}
