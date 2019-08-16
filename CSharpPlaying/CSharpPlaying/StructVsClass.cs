using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpPlaying
{
    /// <summary>
    /// This project captures how structs and classes handled the same logic differently as structs are value type and classes are reference types
    /// </summary>
    public class StructVsClass
    {
        static void Main(string[] args)
        {
            List<check1> lst = check1.GetChecks();
            var output = lst.GroupBy(x => x.Name).ToList();

            Console.WriteLine("Struct output");
            output.ForEach(x =>
            {
                x.ToList().ForEach(y =>
                {
                    y.Prop = y.Prop * 10;
                });
            });
            lst.ForEach(x =>
            {
                Console.WriteLine(x.Prop); ;
            });

            Console.WriteLine("//////////////////////////////////////////////////////////////////////////////////");

            Console.WriteLine("\n CLass output");
            List<check2> lst1 = check2.GetChecks();
            var output1 = lst1.GroupBy(x => x.Name).ToList();
            output1.ForEach(x =>
            {
                x.ToList().ForEach(y =>
                {
                    y.Prop = y.Prop * 10;
                });
            });
            lst1.ForEach(x =>
            {
                Console.WriteLine(x.Prop); ;
            });

        }
    }

    public struct check1
    {
        public int Prop { get; set; }
        public string Name { get; set; }

        public static List<check1> GetChecks()
        {
            return new List<check1> {
                new check1 { Prop = 1,Name="Rahul" },
                new check1 { Prop = 2 ,Name="Rahul"}
            };
        }
    }
    public class check2
    {
        public int Prop { get; set; }
        public string Name { get; set; }
        public static List<check2> GetChecks()
        {
            return new List<check2> {
                new check2 { Prop = 1, Name="Rahul"},
                new check2 { Prop = 2 ,Name="Rahul"}
            };
        }
    }
}

