using System;
using System.Text;

namespace CSharpPlaying
{
    public class Programme
    {
        static void Main(string[] args)
        {
            StringBuilder sb = null;

            string s2 = sb?.ToString() ?? "Nothing";

            Console.WriteLine(s2);
        }  
    }
}
