extern alias W1;//Using extern alias
extern alias W2;//Using extern alias
using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Text;
using static System.Console;



namespace CSharpPlaying
{
    public delegate int Transformer(int x);
    public class Util
    {
        public static void Transform(int[] values, Transformer t)
        {
            for (int i = 0; i < values.Length; i++)
            {
                values[i] = t(values[i]);
            }
        }
    }
    public class Programme
    {
        static void Main(string[] args)
        {
            int[] values = { 1, 2, 3 };
            Transformer t = Square;
            t += Cube;
            Util.Transform(values, t);
            foreach (int  i in values)
            {
                Console.WriteLine(i+" ");
            }
           
        }
        static int Square(int x) => x * x;
        static int Cube(int x) => x * x * x;


    }
}
