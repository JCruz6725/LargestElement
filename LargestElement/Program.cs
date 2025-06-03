using System.Data;
using System.Numerics;
using System.Security;
using System.Text;

namespace LargestElement {
    internal static class LinkListExtension {
        public static void SwapCurrentWithNext(this LinkedList<int> linklist, LinkedListNode<int> current) {
            if(current.Next is null)
                throw new InvalidCastException("Cannot swap current node with next node because current is last.");
        
            LinkedListNode<int> tempNode = new(current.Next.Value);
            linklist.Remove(current.Next);
            linklist.AddBefore(current, tempNode);
        }    
    }


    internal class Program {

        /// <summary>
        /// Sort an int array using 'Bubble sort' algorithm.
        /// </summary>
        /// <param name="array"></param>
        /// <returns>IEnumerable<int> in ascending order</returns>
        /// <exception cref="ArgumentException"></exception>
        public static IEnumerable<int> Sort(int[] array) {
            if (array.Length == 0)
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
        
        
        public static int GetNthLargest(int[] arr, int n) {
            int[] sorted_arrar = Sort(arr).ToArray();
            return sorted_arrar[sorted_arrar.Length - n];
        }


        static string ArrayToString(IEnumerable<int> arr) {
            if (arr is null || !arr.Any())
                return "[]";

            StringBuilder sb = new();
            sb.Append("[");
            foreach(var item in arr) {
                sb.Append(item + ", ");
            }   
            sb = sb.Remove(sb.Length - 2, 2);
            sb.Append("]");
            return sb.ToString();
        }


        static void Arrays(int[][] arr) { 

            for (int i = 0; i < arr.Length; i++) {
                Console.WriteLine($"***Test {i+1} **********");

                try {
                    Console.WriteLine(ArrayToString(arr[i]));
                    int[] swapped_array = Sort(arr[i]).ToArray();
                    Console.WriteLine(ArrayToString(swapped_array));
                }
                catch(Exception ex ) {
                    Console.WriteLine($"Error: {ex.Message}");
                    Console.WriteLine();
                    Console.WriteLine(ex.StackTrace);
                }
                Console.WriteLine("********************\n");
            }
        }

        static void Main(string[] args) {
            Arrays([
                [],
                [3, 1, 2, 4, 5],
                [5, 4, 3, 2, 1],
                [1, 1, 1, 1, 1],
                [33,5,7,11,99,100,-45],
                [0, -1, -2, -3, -4]
            ]);
        }
    }
}
