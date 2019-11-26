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

   
    public class Programme
    {
        static void Main(string[] args)
        {
            SqlBoolean SQ = new SqlBoolean();
            if(SQ)
            Console.WriteLine(true);
            else if(!SQ)
                Console.WriteLine(false);
            else
                Console.WriteLine("null");

        }
    }



    public struct SqlBoolean
    {
        public static bool operator true(SqlBoolean x)
        => x.m_value == True.m_value;
        public static bool operator false(SqlBoolean x)
        => x.m_value == False.m_value;
        public static SqlBoolean operator !(SqlBoolean x)
        {
            if (x.m_value == Null.m_value) return Null;
            if (x.m_value == False.m_value) return True;
            return False;
        }
        public static readonly SqlBoolean Null = new SqlBoolean(0);
        public static readonly SqlBoolean False = new SqlBoolean(1);
        public static readonly SqlBoolean True = new SqlBoolean(2);
        private SqlBoolean(byte value) { m_value = value; }
        private byte m_value;
    }
}
