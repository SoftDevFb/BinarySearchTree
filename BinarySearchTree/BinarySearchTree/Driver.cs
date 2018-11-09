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
    class Driver
    {
        static void Main(string[] args)
        {
            BinaryTree theTree = new BinaryTree();
            theTree.Insert(23);
            theTree.Insert(43);
            theTree.Insert(12);
            theTree.Insert(54);
            theTree.Insert(22);
            theTree.Insert(76);
            theTree.Insert(54);
            theTree.Insert(34);
            Console.WriteLine("Inorder Traversal : ");
            theTree.InorderTransveral(theTree.ReturnRoot());
            Console.WriteLine(" ");

            //Checks each node of the tree and outputs if node is present or not
            //using Search()
            Console.WriteLine(" ");
            theTree.Search(theTree.root, 2);
            Console.ReadKey();
        }
    }
}
