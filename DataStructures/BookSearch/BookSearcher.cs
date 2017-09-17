using System;
using System.Text.RegularExpressions;

namespace BookSearch {
    internal class BookSearcher {
        private string[] reference;

        TreeNode root;

        public BookSearcher(string[] reference) {
            this.reference = reference;

            BuildTree();
        }

        private void BuildTree() {
            root = new TreeNode();
            foreach (var word in reference) {
                root.AddBranch(word);
            }
        }

        internal static string CleanStr(string str) {
            Regex rgx = new Regex("[^a-zA-Z0-9 -]");
            return rgx.Replace(str, "");
        }

        internal void Find(string[] array) {
            foreach (var word in array) {
                Find(word);
            }
        }

        internal void Find(string word) {
            if (root.HasBranch(word)) {
                Console.WriteLine(word);
            }
        }
    }

    internal class TreeNode {
        public int LeafCount;

        TreeNode[] nodes = new TreeNode[127];

        internal void AddBranch(string word) {
            char letter = word[0];

            if (nodes[letter] == null) {
                nodes[letter] = new TreeNode();
            }

            word = word.Remove(0, 1);
            if (String.IsNullOrEmpty(word)) {
                LeafCount++;
            } else {
                nodes[letter].AddBranch(word);
            }
        }

        internal bool HasBranch(string word) {
            char letter = word[0];
            if (nodes[letter] == null) return false;

            word = word.Remove(0, 1);

            if (String.IsNullOrEmpty(word)) {
                return LeafCount > 0;
            }
            return nodes[letter].HasBranch(word);
        }
    }
}