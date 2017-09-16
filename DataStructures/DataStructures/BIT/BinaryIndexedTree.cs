using System.Collections.Generic;

namespace DataStructures.BIT {
    /// <summary>
    /// Implementation of a Binary Indexed Tree (Fennwick Tree)
    /// </summary>
    public class BinaryIndexedTree {

        private List<int> _list;

        /// <summary>
        /// Initialize BIT with list in O(n)
        /// </summary>
        public BinaryIndexedTree(IList<int> list) {
            _list = new List<int>();
            _list.Add(0);
            _list.AddRange(list);

            for (int index = 1; index < _list.Count; index++) {
                int index2 = index + (index & -index);
                if (index2 < _list.Count) {
                    _list[index2] += _list[index];
                }
            }
        }

        /// <summary>
        /// Computes prefix sum of up to including the indexTo element
        /// </summary>
        public int SumTo(int indexTo) {
            int result = 0;
            for (++indexTo; indexTo > 0; indexTo -= indexTo & -indexTo) {
                result += _list[indexTo];
            }
            return result;
        }

        /// <summary>
        /// Computes the range sum between two indices (both inclusive)
        /// </summary>
        public int SumRange(int from, int to) {
            return SumTo(to) - SumTo(from - 1);
        }

        /// <summary>
        /// Add a value to the index element
        /// </summary>
        public void Update(int index, int add) {
            for (++index; index < _list.Count; index += index & -index) {
                _list[index] += add;
            }
        }
    }
}
