using DataStructures.BinaryTree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchAlgorithms {
    class Program {
        static void Main(string[] args) {
            var tree = new BinaryNode<char>('A');
            var leftNode = new BinaryNode<char>('B');
            var rightNode = new BinaryNode<char>('S');
            leftNode.LeftNode = new BinaryNode<char>('C');
            leftNode.RightNode = new BinaryNode<char>('D');
            tree.LeftNode = leftNode;
            rightNode.LeftNode = new BinaryNode<char>('H');
            rightNode.LeftNode.LeftNode = new BinaryNode<char>('G');
            rightNode.LeftNode.RightNode = new BinaryNode<char>('I');
            rightNode.RightNode = new BinaryNode<char>('J');
            rightNode.RightNode.LeftNode = new BinaryNode<char>('M');
            tree.RightNode = rightNode;

            var DFS = new DepthFirstSearch<char>();
            DFS.Explore(tree);

            var BFS = new BreadthFirstSearch<char>();
            BFS.Explore(tree);

            Console.ReadKey();
        }
    }
}
