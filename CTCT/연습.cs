using System;
using static System.Console;

namespace  BrainCSharp
{
    class 연습{
          static void Main(string[] args){
                if(args.Length == 0){
                      Console.WriteLine("사용법 : 연습.exe <이름>");
                      return;
                }

                WriteLine("Hello, {0}!", args[0]);
          }
    }
}
