namespace LargestElement {
    internal class TestCase {
        public required int[] InputArray { get; init; }
        public required int K { get; init; }
        public int[] SortedArray { get; set; } = [];
        public int? NthLargestElement { get; set; } = null;
        public Exception? Error { get; set; } = null;
    }


}