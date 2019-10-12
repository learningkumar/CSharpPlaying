extern alias W1;//Using extern alias
extern alias W2;//Using extern alias
using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Text;
using static System.Console;



namespace CSharpPlaying
{
    public class Programme
    {
        static void Main(string[] args)
        {
            Func<string> f1 = () => "Hello World";
            Func<object> f2 = f1;
            Console.WriteLine(f2());

            Action<object> ao = (object o) => Console.WriteLine(o);
            Action<string> asa = ao;
            asa("Nishet");
        }
    }
}
