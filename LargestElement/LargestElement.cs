namespace LargestElement {
    internal class LargestElement { 
        /// <summary>
        /// Sort an int array using 'Bubble sort' algorithm.
        /// </summary>
        /// <param name="array"></param>
        /// <returns>IEnumerable<int> in ascending order</returns>
        /// <exception cref="ArgumentException"></exception>
        public static IEnumerable<int> Sort(int[] array) {
            if(array.Length == 0)
                throw new ArgumentException("Array cannot be empty.", nameof(array));

            LinkedList<int> linklist = new(array);
            LinkedListNode<int>? current = linklist.First ;

            bool is_sorted = false;
            bool swapped = false;
            while(!is_sorted) {
                while(current is not null) {
                    if(current.Value > current.Next?.Value) {
                        linklist.SwapCurrentWithNext(current);
                        swapped = true;
                    }
                    else {
                        current = current.Next;
                    }
                }
                if(swapped) {
                    current = linklist.First;
                    swapped = false;
                }
                else {
                    is_sorted = true;
                }
            }
            return [.. linklist];
        }

        /// <summary>
        /// Get the nth largest element from sorted int array.
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="k"></param>
        /// <returns>NthLargest number</returns>
        /// <exception cref="ArgumentException"></exception>
        public static int GetNthLargest(int[] arr, int k) {
            if(k > arr.Length)
                throw new ArgumentException("k cannot be greater than the length of the array.");

            int[] sorted_arrar = Sort(arr).ToArray();
            return sorted_arrar[sorted_arrar.Length - k];
        }
    }
}