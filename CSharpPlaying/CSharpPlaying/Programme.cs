extern alias W1;//Using extern alias
extern alias W2;//Using extern alias
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Controls;
using System.Xml.Serialization;
using static System.Console;



namespace CSharpPlaying
{
    public struct Demo
    {
        public int M, N;
    }
    public class Programme
    {

        // pn is a pointer to integer type
        static unsafe void Square(int* pn)
        {
            *pn = *(pn) * *pn;
        }
        static void Main(string[] args)
        {
            int n = 10;
            unsafe
            {
                Square(&n);
            }
            Console.WriteLine(n);

            int[] ar = { 1, 2, 3, 4 };
            unsafe
            {

                fixed (int* par = ar)
                {
                    PrintArray(par, ar.Length);

                }

                //Another way of initialising stack
                int* arr = stackalloc int[10];
                Console.WriteLine(arr[8]);
            }

            //Struct pointers demo
            Demo d;
            d.M = 9;
            d.N = 4;
            unsafe
            {
                PrintDemo(&d);
            }

        }


        //pointers with struct
        static unsafe void PrintDemo(Demo* demo)
        {
            Console.WriteLine((*demo).N + " " + (*demo).M);
            Console.WriteLine(demo->N + " " + demo->M);
        }

        //for array pointers one needs to pass the lenth also with the array's first element address
        static unsafe void PrintArray(int* par, int len)
        {
            for (int i = 0; i < len; i++)
            {
                Console.WriteLine(*(par + i) + " " + par[i]);
            }
        }
    }
}
