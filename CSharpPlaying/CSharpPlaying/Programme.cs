extern alias W1;//Using extern alias
extern alias W2;//Using extern alias
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Windows.Controls;
using static System.Console;



namespace CSharpPlaying
{

    public class Programme
    {
        static void Main(string[] args)
        {
            dynamic d = new Duck();
            d.Quack();
            d.Waddle();
        }
    }
    public class Duck:DynamicObject
    {
        public override bool TryInvokeMember(InvokeMemberBinder binder, object[] args, out object result)
        {
            Console.WriteLine(binder.Name+" method was called");
            result = null;
            return true;
        }
    }
 
}
