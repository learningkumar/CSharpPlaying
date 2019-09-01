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

            FibonacciSequence();
        }
        static void FibonacciSequence()
        {
            for (int i = 0, prevFib = 1, currFib = 1; i < 10; i++)
            {

                Console.WriteLine(currFib);
                int newFib = currFib + prevFib;

                prevFib = currFib;
                currFib = newFib;


            }
        }
    }

}
