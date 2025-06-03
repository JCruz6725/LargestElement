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
}