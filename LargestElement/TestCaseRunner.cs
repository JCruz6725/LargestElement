namespace LargestElement {
    internal class TestCaseRunner { 
        public static void Run(TestCase[] testCases) {
            for(int i = 0; i < testCases.Length; i++) {
                TestCase tCase = testCases[i];
                try {
                    tCase.SortedArray = LargestElement.Sort(tCase.InputArray).ToArray();
                    tCase.NthLargestElement = LargestElement.GetNthLargest(tCase.SortedArray, tCase.K);
                }
                catch(Exception ex) {
                    tCase.Error = ex;
                }
            }
        }
    }
}