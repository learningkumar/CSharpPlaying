extern alias W1;//Using extern alias
extern alias W2;//Using extern alias
using System;
using System.Text;
using static System.Console;
//using Outer.Middle.Inner;



namespace Outer
{
    class class3 { }
    namespace Middle
    {
        class class4 { }
    }
}

namespace Outer.Middle.Inner
{
    class class1 { }
    class class2 { }
}

namespace Programme
{
    class classB { };
}
namespace CSharpPlaying
{


    public class Programme
    {

        class classB { };
        static void Main(string[] args)
        {
            new W1.Nishet.class1();//Use of extern aliased namespace for this we need to alias the testing dll to W1 in its properties
            new W1.Nishet.class1();//Use of extern aliased namespace for this we need to alias the testing dll to W2 in its properties
            new global::Programme.classB();//use of global keyword in case conflict is present even after fully qualified name like programme class contains classb and namespace programme also contains classb so in order to use namespace class b we had to use global keyword as otherwise the default behaviour of compiler is to use the enclosing namespace members 


        }



    }

}
