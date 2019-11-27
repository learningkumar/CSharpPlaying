extern alias W1;//Using extern alias
extern alias W2;//Using extern alias
using System;
using System.Collections.Generic;

using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Windows.Controls;
using static System.Console;



namespace CSharpPlaying
{

    class Test
    {
        public void Foo(object x) { } // This method always wins
    }
    static class Extensions
    {
        public static void Foo(this Test t,int x,string f) { }
    }

    public class Programme
    {
        static void Main(string[] args)
        {
          
        }
    }
    public static class Sequnce
    {
        public static T FirstLetter<T>(this IEnumerable<T> sequence)
        {
            foreach (T item in sequence)
            {
                return item;
            }
            throw new InvalidOperationException("No Elements");
        }
    }
    public static class StringHelper
    {
        public static bool isCaptilized(this string s,int b)
        {
            if (string.IsNullOrEmpty(s))
                return false;
            else return char.IsUpper(s[0]);
        }
    }
}
