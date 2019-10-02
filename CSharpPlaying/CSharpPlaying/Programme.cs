extern alias W1;//Using extern alias
extern alias W2;//Using extern alias
using System;
using System.Text;
using static System.Console;



namespace CSharpPlaying
{
    public class Bob<T>
    {
        public static int Count;
    }
    public class Programme
    {
        static void Main(string[] args)
        {
            Console.WriteLine(++Bob<int>.Count);
            Console.WriteLine(++Bob<int>.Count);
            Console.WriteLine(++Bob<string>.Count);
            Console.WriteLine(++Bob<string>.Count);

           // The above is the behaviour of generics on static items
            Console.WriteLine("/////////////////////////////////////////");
            Baloon b1 = new Baloon { Color = "Red" };
            Baloon b2 = new Baloon { Color = "Red" };
            Console.WriteLine(b1.Equals(b2));
            //THe above ahows generic types can privide themselvesas the generic argument

            var stack = new Stk<int>();
            stack.Push(4);
            stack.Push(5);
            Console.WriteLine(stack.Pop());
            //The above shows a generic stack

            var ty = typeof(Stk<>);

            Console.WriteLine(ty.Name);
            Console.WriteLine(default(Stk<int>));

            //The above shows that generic types can remain open(i.e no type argument provided ) if they are used with typeof operator

            int a = 10;
            int b = 20;
            Swap(ref a, ref b);
            Console.WriteLine(b);
            //The above is a generic swap method
            Console.WriteLine(Max(a, b));
            //The above is an implementation of a genric method with constraint on generic type parameter
        }
        static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }
        static T Max<T>(T a, T b) where T : IComparable<T>
        {
            return a.CompareTo(b) > 0 ? a : b;
        }
    }

    public class Baloon : IEquatable<Baloon>
    {
        public string Color { get; set; }
        public bool Equals(Baloon other)
        {
            if (other == null)
                return false;
            else
                return this.Color == other.Color;
        }
        
    }
    public class Stk<T, y>
    {

    }
    public class Stk<T> 

    {
        int position;
        T[] obj = new T[100];
        public void Push(T o) => obj[position++] = o;
        public T Pop() => obj[--position];

        public override string ToString()
        {
            return "Nishet";
        }

    }
}
