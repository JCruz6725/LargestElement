namespace LargestElement {
    internal class Program {
        static void Main(string[] args) {
            TestCase[] t = [
                new() { InputArray = [], K = 0},
                new() { InputArray = [1,2], K = 15},
                new() { InputArray = [3, 1, 2, 4, 5], K = 2 },
                new() { InputArray = [5, 4, 1], K = 2},
                new() { InputArray = [1, 1, 1], K = 3 },
                new() { InputArray = [33,5,7,11,99,100,-45], K = 3 },
                new() { InputArray = [0, -1, -2, -3, -4], K = 2 },
                new() { InputArray = [66,98,53,64,33,98,82,98,49,32], K = 5 }
                ];
            TestCaseRunner.Run(t);
            TestCaseRederer.RenderAll(t);   
        }
    }
}