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
    public delegate int Transformer(int i);
    public class Programme
    {
       
        static void Main(string[] args)
        {
            //Capturing iteration variable in a lambda expression in a for loop causes the following behaviour
            Action[] action = new Action[3];
            for (int j = 0; j < 3; j++)
            {
                action[j] = () => Console.WriteLine(j);
            }
            foreach (Action item in action)
            {
                item();//this will print 333
            }

            //Same as above but if we want some not surprising behaviour then this
            for (int k = 0; k < 3; k++)
            {
                int num = k;
                action[k] = () => Console.WriteLine(k);
            }
            foreach (Action item in action)
            {
                item();//this will print 012
            }



            //iteration variable capturing in foreach loop causes differnet behaviour than the for loop as the iterating variable in foreach loop is immutable
            int i = 0;
            var ran = Enumerable.Range(1, 3);
            foreach (var item in ran)
            {
                action[i++] = () => Console.WriteLine(item);
            }

            foreach (var item in action)
            {
                item();
            }
          
        }
       
    }
}
