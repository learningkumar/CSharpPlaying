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
    public delegate void ProgressReporter(int percentComplete);
    public class Util
    {
        
        public static void Transform(int[] values, Transformer t)
        {
            
            for (int i = 0; i < values.Length; i++)
            {
                values[i] = t(values[i]);
            }
        }
        public static void HardWork(ProgressReporter p)
        {
            for (int i = 0; i < 10; i++)
            {
                p(i * 10);
                System.Threading.Thread.Sleep(100);
            }
        }
    }
    public class Programme
    {
        class X
        {
            public void InstanceProgress(int percentComplete)
            => Console.WriteLine(percentComplete);
        }
        static void Main(string[] args)
        {
            X x = new X();
            ProgressReporter p1 = x.InstanceProgress;
            p1(99); // 99
            Console.WriteLine(p1.Target == x); // True
            Console.WriteLine(p1.Method); // Void InstanceProgress(Int32)
            ProgressReporter p = WriteProgressToConsole;
            p += WriteProgressToFile;
            Util.HardWork(p);
        }
        static void Main1(string[] args)
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

        static void WriteProgressToConsole(int percentComplete) => Console.WriteLine(percentComplete);
        static void WriteProgressToFile(int percentComplete) => System.IO.File.WriteAllText("progress.txt", percentComplete.ToString());

    }
}
