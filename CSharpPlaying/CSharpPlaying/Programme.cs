using System;
using System.Text;

namespace CSharpPlaying
{
    public class Programme
    {
        static void Main(string[] args)
        {
           string first = "Nishet";
            string second = "Kumar";
            Swap(ref first,ref second);
            Console.WriteLine(first);
            Console.WriteLine(second);
        }
       
        static void Swap(ref string first, ref string second)
        {
            string temp = first;
            first = second;
            second = temp;
        }
    }
}
