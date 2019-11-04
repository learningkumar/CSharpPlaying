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
            foreach (char c in "beer")
            {
               // Console.WriteLine(c);
            }
            using(var enumerator = "beer".GetEnumerator())
            {
                while(enumerator.MoveNext())
                {
                    Console.WriteLine(enumerator.Current);
                }
            }
        }
    }
}
