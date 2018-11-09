using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Developer:  Frankie Barrios
/// Date:       11/1/2018
/// Purpose:    Create a class for a Binary Tree node.  
///             Your node should contain a single character
///             data member plus the two child node references
///             necessary for it to be part of a Binary Tree. 
///             Call these data members Letter, Left, and Right.  
///             Create a constructor method that will initialize 
///             the character to '\0' and the two child node 
///             references each to null.  Create Get and Set methods 
///             for each of the three data members.  Create a main 
///             method to test your code.
/// </summary>
/// 

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
