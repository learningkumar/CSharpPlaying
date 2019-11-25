extern alias W1;//Using extern alias
extern alias W2;//Using extern alias
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Windows.Controls;
using static System.Console;



namespace CSharpPlaying
{

    //Operator overloading
    public struct Note
    {
       public int value;
        public Note(int semiTonesFromA)
        {
            value = semiTonesFromA;
        }
        public static Note operator +(Note x, int semiTones) => new Note(x.value + semiTones);
    }
    public class Programme
    {
        static void Main(string[] args)
        {
            //Operator overloading
            Note note = new Note(3);
            Note note1 = note + 4;

          


            //var sequence = Foo(false);

            //IEnumerator<string> er = sequence.GetEnumerator();
            //while (er.MoveNext())
            //    Console.WriteLine(er.Current);
            //foreach (string item in Foo(true))
            //{
            //    Console.WriteLine(item);
            //}
            //foreach (int fib in EvenFibsOnly(Fibs(3)))
            //{
            //    Console.WriteLine(fib);
            //}
        }
        static IEnumerable<int> Fibs(int FibCount)
        {
            for (int i = 0, prevFib = 1, currFib = 1; i < FibCount; i++)
            {
                yield return prevFib;
                int newFib = prevFib + currFib;
                prevFib = currFib;
                currFib = newFib;
            }
        }
        static IEnumerable<int> EvenFibsOnly(IEnumerable<int> fibNums)
        {
            foreach (int item in fibNums)
            {
                if (item % 2 == 0)
                    yield return item;
            }
        }
        static IEnumerable<string> Foo(bool breakEarly)
        {
            yield return "one";
            yield return "two";
            if (breakEarly)
                yield break;
            yield return "three";

        }
    }
}
