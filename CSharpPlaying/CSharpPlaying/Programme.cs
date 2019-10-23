extern alias W1;//Using extern alias
extern alias W2;//Using extern alias
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using static System.Console;



namespace CSharpPlaying
{
    public delegate int Transformer(int i);
    public class Programme
    {
        public delegate int Transformer(int num);
       
        static void Main(string[] args)
        {
            Transformer t = delegate (int x) { return x * x; };
            Console.WriteLine(t(8));
          
        }
       
    }
}
