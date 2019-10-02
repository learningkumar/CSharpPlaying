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

        }
        int FooV<T>(T arg) =>(int)(object)arg;
        StringBuilder Foo<T>(T arg) 
        {
            StringBuilder sb = arg as StringBuilder;
            if (sb != null)
                return sb;
            return null;
        }
    }
}
