using System;

namespace Nishet
{

    public interface i1
    {
        void foo();
    }
    public class Another
    {
        public static object Method => new class1();
    }
  internal  class class1 :i1
    {
        public const int Number = 20;
        public void foo()
        {
            Console.WriteLine("Inside new foo");
        }
    }
    class class2 { }
}