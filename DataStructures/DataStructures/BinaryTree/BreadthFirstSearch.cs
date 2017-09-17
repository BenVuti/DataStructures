using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.BinaryTree {
    /// <summary>
    /// Simple implementation of BFS
    /// </summary>
    public class BreadthFirstSearch<T> {
        private Queue<BinaryNode<T>> stack = new Queue<BinaryNode<T>>();
        private IList<T> output = new List<T>();

        internal void Explore(BinaryNode<T> node) {
            output.Add(node.Value);

            if (node.IsRoot) {
                // Only the root node is to be added this way
                // doing that on all node would cause an infinite loop
                stack.Enqueue(node);
            }

            // queue childs for exploration
            if (node.LeftNode != null) {
                stack.Enqueue(node.LeftNode);
            }
            if (node.RightNode != null) {
                stack.Enqueue(node.RightNode);
            }
            // dequeue current node
            stack.Dequeue();
            if (stack.Count == 0) {
                // when the queue is empty, we are done and can ouptut the result
                Console.WriteLine(String.Join(" ", output));
            } else {
                // explore next node
                Explore(stack.Peek());
            }
        }
    }
}
