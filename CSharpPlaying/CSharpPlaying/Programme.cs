extern alias W1;//Using extern alias
extern alias W2;//Using extern alias
using System;
using System.Text;
using static System.Console;



namespace CSharpPlaying
{
   
    public class Stk
    {
        int position;
        object[] obj = new object[10];
        public void Push(object o) { obj[position++] = o; }
        public object Pop() { return obj[--position]; }
    }
    public class Programme
    {
        static void Main(string[] args)
        {
            Stk s = new Stk();
            s.Push(5);
            s.Push(8);
            s.Pop();
        }
       
    }
}
