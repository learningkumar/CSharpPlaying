using System;
using System.Text;

namespace CSharpPlaying
{
    public class Programme
    {
        static void Main(string[] args)
        {
            int x = 8;
            Foo(x);
            Console.WriteLine("Main value is " + x);

            StringBuilder sb = new StringBuilder();
            Foo(sb);
            Console.WriteLine("The string is " + sb.ToString());
        }
        static void Foo(int p)
        {
            p = p + 1;
            Console.WriteLine("Foo value is " + p);
        }

        static void Foo(StringBuilder fooSB)
        {
            fooSB.Append("test");
            fooSB = null;
        }
    }
}
