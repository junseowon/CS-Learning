using System;

namespace VariableCS
{
    class Var
    {
        //필드 (클래스 내에서 공통적으로 사용되는 전역 변수)
        int globalVar;
        const int MAX = 1024;

        public void Method1()
        {
            //로컬 변수
            int localVar;

            // 아래 할당이 없다면 에러가 날 수 있음.
            localVar = 100;

            Console.WriteLine(globalVar);
            Console.WriteLine(localVar);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
          Var obj = new Var();
          obj.Method1();
        }
    }

}
