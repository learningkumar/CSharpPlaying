extern alias W1;//Using extern alias
extern alias W2;//Using extern alias
using System;
using System.Text;
using static System.Console;



namespace CSharpPlaying
{
    public class Testing
    {
        public string Name;
        
        public Testing() { }

        /// <summary>
        /// Use the static method Hello
        /// </summary>
        /// <param name="name"></param>
        private Testing(string name)
            {  }
        public static  Testing Hello() { return new Testing(""); }
    }

    public class Panda
    {
        string[] words = "This is a sentence".Split();

        //Indexer implimentatiion
        public string this [int wordNum]
        {
            get { return words[wordNum]; }
            set { words[wordNum] = value; }
        }
        public int Population {  get; private set; } 
        public Panda Mate;
        public void Marry(Panda partner)
        {
            Mate = partner;
            partner.Mate = this;
        }
    }

    public class Programme
    {
        static void Main(string[] args)
        {
            Panda p = new Panda();
            p[3] = "donkey";
            Console.WriteLine(p[3]);
        }
        
    }

}
