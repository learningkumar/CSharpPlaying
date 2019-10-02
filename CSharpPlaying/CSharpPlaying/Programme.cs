extern alias W1;//Using extern alias
extern alias W2;//Using extern alias
using System;
using System.Text;
using static System.Console;



namespace CSharpPlaying
{
    public class Animal { }
    public class Bear : Animal { }
    public class Camel : Animal { }
    public class Stk<T>
    {
        int position;
        T[] items = new T[100];
        public void Push(T item) => items[position++] = item;
        public T Pop() =>items[--position];
    }
    public class ZooCleaner
    {
        //A way to bypass covariance restriction on class types also a very good example of how gnereics method to be written
        public static void Wash<T>(Stk<T> animals) where T:Animal
        { }
    }
    public class Programme
    {

        static void Main(string[] args)
        {
            Stk<Bear> bears = new Stk<Bear>();
            ZooCleaner.Wash(bears);
            Stk<Animal> animals = bears;//This line is causing compile time error as it shows that type covariance is not automatic i.e though bear can be implicitly reference conveted to animal howver the generic bear type can be implicitly reference coverted  to generic animal type
        }
       }
    }
}
