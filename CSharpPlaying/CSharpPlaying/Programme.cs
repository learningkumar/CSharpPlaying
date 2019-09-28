extern alias W1;//Using extern alias
extern alias W2;//Using extern alias
using System;
using System.Text;
using static System.Console;



namespace CSharpPlaying
{
    public class Programme
    {
        static void Main(string[] args)
        {
            var stack = new Stk<int>();
            stack.Push(4);
            stack.Push(5);
            Console.WriteLine(stack.Pop());

            int a = 10;
            int b = 20;
            Swap(ref a, ref b);
            Console.WriteLine(b);
            
        }
        static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }
    }
    public class Stk<T>
    {
        int position;
        T[] obj = new T[100];
        public void Push(T o) => obj[position++] = o;
        public T Pop() => obj[--position];

     
    }
}
