using System;
using System.Text;

namespace CSharpPlaying
{
    public class Programme
    {
        static void Main(string[] args)
        {            
            string a, b;
            Split("nishet kumar tiwari",out a,out b);
            /////////////////////////////
            Foo(out x);
        }      
       
        static void Split(string name,out string firstName,out string Lastname)
        {
            int i = name.LastIndexOf(' ');
            firstName = name.Substring(0, i);
            Lastname = name.Substring(i + 1);
        }
        static int x;
        static void Foo(out int y)
        {
            Console.WriteLine(  x);
            y = 11;
            Console.WriteLine(x);
        }
    }
}
