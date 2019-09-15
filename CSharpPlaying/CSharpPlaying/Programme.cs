extern alias W1;//Using extern alias
extern alias W2;//Using extern alias
using System;
using System.Text;
using static System.Console;



namespace CSharpPlaying
{
    public  class Base
    {
        public Base()
        {

        }
        public Base(int number)
        {

        }
        public virtual  void Foo() { Console.WriteLine("Inside base class"); }
    }

    public class Overrider:Base
    {
        public Overrider()
        {
                
        }
        public  override void Foo() { Console.WriteLine("Inside Overrider class"); }
    }
    public class AnotherOverrider:Overrider
    {
        public override void Foo()
        {
            base.Foo();
        }
    }

    public class Hider : Base
    {
        public new void Foo() {Console.WriteLine("Inside Hider class"); }
    }

    public class Programme
    {
        static void Main(string[] args)
        {
            
            Overrider o = new Overrider();
            Base b1 = o;
            o.Foo();
            b1.Foo();

            Hider h = new Hider();
            Base b2 = h;
            meth(h);
            meth(b2);
            meth(o);
            meth(b1);
            h.Foo();
            b2.Foo();
        }

        static void meth(Base b)
        {
            b.Foo();
        }

        static void meth(Overrider b)
        {
            b.Foo();
        }
        static void meth(Hider b)
        {
            b.Foo();
        }
    }
}
