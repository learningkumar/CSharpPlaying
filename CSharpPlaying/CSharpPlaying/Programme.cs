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
    public interface IFoo
    {
        void Foo();
    }
    public class Test:IFoo
    {
         void IFoo.Foo() { }
    }
    public class Foo : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged=delegate { };
        void RaiseOnPropertyChanged([CallerMemberName]string propertyName=null)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
        string customerName;    
        public string CustomerName
        {
            get { return customerName; }
            set
            {
                if (value == customerName) return;
                else
                {
                    customerName = value;
                    RaiseOnPropertyChanged();
                }

            }
        }

    }



    public class Programme
    {
        
        private int v;
        static void Main(string[] args)
        {
            Foo();
            INotifyPropertyChanged
        }
        static void Foo([CallerMemberName]string memberName=null,[CallerFilePath]string filePath = null,[CallerLineNumber]int lineNumber=0)
        {
            Console.WriteLine(memberName);
            Console.WriteLine(filePath);
            Console.WriteLine(lineNumber);
        }
        
        static dynamic Mean(dynamic x, dynamic y) => (x + y) / 2;
    }


}
