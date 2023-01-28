using System;

namespace ConsoleApp2
{
    public class SinglePurposeThing
    {
        public int SomeValue{ get; set; }
    }

    public static class ExtensionMethods
    {
        public static void set2Five(this SinglePurposeThing sps)
        {
            sps.SomeValue = 5;
        }
    }
    internal class Program
    {
        static void Set2Five(SinglePurposeThing sps)
        {
            sps.SomeValue = 5;
        }

        static void Main(string[] args)
        {
            var sps = new SinglePurposeThing();
            Set2Five(sps);
            //sps.Set2Five();  was not workıng that why we used ExtensionMethod class
            sps.set2Five();     // we are able to uses after extensıon.
        }
    }
}
