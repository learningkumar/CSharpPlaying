extern alias W1;//Using extern alias
extern alias W2;//Using extern alias
using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Text;
using static System.Console;



namespace CSharpPlaying
{
    public delegate int Transformer(int i);
    public class Programme
    {
        static Func<int> Natural()
        {
            int seed = 0;
            return () => seed++;
        }
        static void Main(string[] args)
        {
            Func<int> fnn = Natural();
            Console.WriteLine(fnn());
            Console.WriteLine(fnn());
            Console.WriteLine(fnn());
            //Transformer tr = x => x * x;
            //Func<int, int> fn = x => x * x;
            //Func<string, string, int> fns = (s1, s2) => s1.Length + s2.Length;
            //Console.WriteLine(fns("hello", "world"));
            //Bar((int x) => Foo(x));
            //Bar<int>(x => Foo(x));
            //Bar<int>(Foo);
        }
        static void Foo<T>(T x) { }
        static void Bar<T>(Action<T> a) { }
    }
}
