extern alias W1;//Using extern alias
extern alias W2;//Using extern alias
using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Text;
using static System.Console;



namespace CSharpPlaying
{
    //Covariance in return type parameter
    public delegate object ObjectRetriever();

    //Contravariance in input parameter
    public delegate void StringAction(string s);
    public class Programme
    {
        static void Main(string[] args)
        {
            StringAction sa = ActionObject;
            sa("Hello");

            ObjectRetriever or = GetObject;
            Console.WriteLine(or());
        }
        static void ActionObject(object o) => Console.WriteLine(o.ToString());
        static string GetObject() => "hello";
    }
}
