using System;

namespace Assignment1_Ben
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] xGrid = { 0, 30 };
            double[] yGrid = { 0, 30 };

            //Letter T
            Rectangle newRec1 = new Rectangle(0, 26, 10, 30);
            Rectangle newRec = new Rectangle(4, 0, 6, 26);
            Union letterT = new Union(newRec, newRec1);

            letterT.Visualize(xGrid,yGrid);

            


            Console.ReadKey();
        }
    }
}
