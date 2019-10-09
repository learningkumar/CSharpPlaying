extern alias W1;//Using extern alias
extern alias W2;//Using extern alias
using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Text;
using static System.Console;



namespace CSharpPlaying
{
    public class Animal { }
    public class Bear : Animal { }
    public class Camel : Animal { }
    public interface IPoppable<out  T>
    {
        T Pop();
    }
    public interface IPushable<in T>
    {
        void Push(T obj);
    }
    public class Stk<T>:IPoppable<T>,IPushable<T>
    {
        int position;
        T[] items = new T[100];
        public void Push(T item) => items[position++] = item;
        public T Pop() => items[--position];
    }
    public class ZooCleaner
    {
        //A way to bypass covariance restriction on class types also a very good example of how gnereics method to be written
        public static void Wash<T>(Stk<T> animals) where T : Animal
        { }
    }
    public class Programme
    {

        static void Main(string[] args)
        {

            
            
            
            Stk<Bear> bears = new Stk<Bear>();
            Stk<Animal> animals = new Stk<Animal>();
            
            bears.Push(new Bear());
            IPoppable<Animal> c = bears;
            //IPoppable<Bear> b = (Stk<Bear>)animals;
            Animal anim = c.Pop();
            Console.WriteLine(anim.GetType().Name);
            IPushable<Animal> ipa = new Stk<Animal>();
            IPushable<Bear> ipb = new Stk<Animal>();
            ipb.Push(new Bear());
            ipa.Push(new Animal());
            ipa.Push(new Bear());

           // Animal bh = c.Pop();
           // ZooCleaner.Wash(bears);
            // Stk<Animal> animals = bears;//This line is causing compile time error as it shows that type covariance is not automatic i.e though bear can be implicitly reference conveted to animal howver the generic bear type can be implicitly reference coverted  to generic animal type


         IComparer<object> comparer =   Comparer<Object>.Default;
            Console.WriteLine( comparer.Compare("a", "b"));
        }
    }
}
