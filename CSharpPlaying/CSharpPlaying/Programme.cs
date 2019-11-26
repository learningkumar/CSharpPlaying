extern alias W1;//Using extern alias
extern alias W2;//Using extern alias
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Windows.Controls;
using static System.Console;



namespace CSharpPlaying
{

    //Operator overloading
    public struct Note
    {
       public int value;
        public Note(int semiTonesFromA)
        {
            value = semiTonesFromA;
        }
        public static Note operator +(Note x, int semiTones) => new Note(x.value + semiTones);
        
        public static implicit operator double(Note n)=> n.value+ 4.5;
        public static explicit operator Note(double d)=>new Note((int)d);
    }
    public class Programme
    {
        static void Main(string[] args)
        {
            Note n = new Note(3);
            double d = n;
            Note ng = (Note)d; 
        }
    }
}
