extern alias W1;//Using extern alias
extern alias W2;//Using extern alias
using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Text;
using static System.Console;



namespace CSharpPlaying
{
    public delegate T Transformer<T>(T item);
    public class Util
    {
        public static void Transform<T>(T[] values,Func<T,T> t)
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

            Util.Transform(values, Square);

            foreach (int item in values)
            {
                Console.WriteLine(item);
            }
        }
        public static int Square(int x) => x * x;
    }
}
