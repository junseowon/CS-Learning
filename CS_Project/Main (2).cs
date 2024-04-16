using System;

namespace MyCompiler {
    class Program {
        public static void Main(string[] args) {
            //문자열 변수
            string s1 = "C#";
            string s2 = "Programming";

            //문자 변수
            char c1 = 'A';
            char c2 = 'B';

            //문자열 결합
            string s3 = s1 + " " + s2;
            Console.WriteLine("String : {0}", s3);

            //부분 문자열 발췌
            string s3_sub_string = s3.Substring(1, 5);
            Console.WriteLine("Substring : {0}", s3_sub_string);
        }
    }
}