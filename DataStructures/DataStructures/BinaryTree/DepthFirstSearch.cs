using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.BinaryTree {
    /// <summary>
    /// Simple DFS implementation
    /// </summary>
    public class DepthFirstSearch<T> {
        private Stack<BinaryNode<T>> stack = new Stack<BinaryNode<T>>();
        private IList<T> output = new List<T>();

        internal void Explore(BinaryNode<T> node) {
            output.Add(node.Value);
            stack.Push(node);
            if (node.LeftNode != null) {
                Explore(node.LeftNode);
            }
            if (node.RightNode != null) {
                Explore(node.RightNode);
            }
            stack.Pop();
            if (stack.Count == 0) {
                Console.WriteLine(String.Join(" ", output));
            }
        }
    }
}
