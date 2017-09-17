using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.BinaryTree {
    public class BinaryNode<T> {
        public BinaryNode() { }
        public BinaryNode(T value) {
            val = value;
        }

        private T val;
        public T Value {
            get { return val; }
        }

        public BinaryNode<T> Parent { get; set; }

        private BinaryNode<T> leftNode;
        public BinaryNode<T> LeftNode {
            get => leftNode;
            set {
                leftNode = value;
                value.Parent = this;
            }
        }

        private BinaryNode<T> rightNode;
        public BinaryNode<T> RightNode {
            get => rightNode;
            set {
                rightNode = value;
                value.Parent = this;
            }
        }


        public bool IsRoot => Parent == null;
    }
}
