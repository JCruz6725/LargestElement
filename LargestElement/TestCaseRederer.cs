using System.Text;

namespace LargestElement {
    internal static class TestCaseRederer  {

        public static void RenderAll(TestCase[] testCases) {
            int count = 1;
            foreach(var testCase in testCases) {
                Console.WriteLine($"*** Test {count++} ***");
                if(testCase.Error is null)
                    Render(testCase);
                else
                    RenderExecption(testCase);
                Console.WriteLine("***********************\n");
            }
        }


        public static void Render(TestCase testCase) {
            StringBuilder sb = new();   
            sb.AppendLine( $"Test Array: {ArrayToString(testCase.InputArray)}");
            sb.AppendLine($"K: {testCase.K}");
            sb.AppendLine();
            sb.AppendLine( $"Sorted: {ArrayToString(testCase.SortedArray)}");
            sb.AppendLine($"Nth Largest Element: {testCase.NthLargestElement}");
            Console.WriteLine(sb.ToString());
        }


        public static void RenderExecption(TestCase tc) {
            if(tc.Error is null)
                return;

            StringBuilder sb = new();   
            sb.AppendLine(tc.Error.Message);
            sb.AppendLine(tc.Error.StackTrace);
            Console.WriteLine(sb.ToString());
        }

        public static string ArrayToString(IEnumerable<int> arr) {
            if(arr is null || !arr.Any())
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



    }
}