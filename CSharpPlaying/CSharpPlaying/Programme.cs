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
            BorderSide b = BorderSide.Left | BorderSide.Right;
            Console.WriteLine(b.ToString());
            
        }
    }

    [Flags]
    public enum BorderSide
    {
        None=0,
        Left = 2,
        Right = 4,
        Top = 8,
        Bottom = 16
    }
}
