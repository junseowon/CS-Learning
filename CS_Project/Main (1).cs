using System;

namespace MyCompiler {
    class Program {
        public static void Main(string[] args) {        
            int[] scores = {80,38,20,56,100};
            int sum = CalculateSum(scores);
            Console.WriteLine(sum);
        }

        static int CalculateSum(int[] scoresArray)
        {
            int sum = 0;
            for(int i = 0; i < scoresArray.Length; i++){
                sum += scoresArray[i];
            }
            return sum;
        }
        
    }
}