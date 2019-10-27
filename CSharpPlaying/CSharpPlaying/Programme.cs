extern alias W1;//Using extern alias
extern alias W2;//Using extern alias
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using static System.Console;



namespace CSharpPlaying
{
    public class Programme
    {
        static int Calc(int x)
        {
            try
            {
                return 10 / x;
            }
            catch 
            {

                throw;
            }
        }
        
    static void Main(string[] args)
    {
            try
            {
                int y = Calc(0);
                Console.WriteLine(y);
            }
            catch ( ArgumentNullException e) when (e.Source=="")
            {

                throw;
            }
    }
}
}
