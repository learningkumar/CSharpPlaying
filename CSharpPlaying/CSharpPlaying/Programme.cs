extern alias W1;//Using extern alias
extern alias W2;//Using extern alias
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using static System.Console;



namespace CSharpPlaying
{
    public class Programme
    {
        
        static void Main(string[] args)
        {
            foreach (int fib in Fibs(3))
            {
                Console.WriteLine(fib);
            }
        }
        static IEnumerable<int> Fibs(int FibCount)
        {
            for (int i = 0,prevFib=1,currFib=1; i < FibCount; i++)
            {
                yield return prevFib;
                int newFib = prevFib + currFib;
                prevFib = currFib;
                currFib = newFib;
            }
        }
    }
}
