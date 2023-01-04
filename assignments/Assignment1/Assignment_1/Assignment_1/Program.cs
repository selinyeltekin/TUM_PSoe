using System;

namespace Assignment_1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please type in X Value");

            double userXGrid = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please type in Y Value");

            double userYGrid = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please type in thickness for letters");
            double thickness = Convert.ToDouble(Console.ReadLine());

            // letter T

            Rectangle letterTRec1 = new Rectangle(0, userXGrid/3, userYGrid-thickness, userYGrid);
            Rectangle letterTRec2 = new Rectangle((userXGrid/6 - thickness), (userXGrid/6 + thickness), 0, userYGrid);
            Union letterT = new Union(letterTRec2 , letterTRec1);

            // letter U
            Rectangle letterURec1 = new Rectangle(userXGrid / 3, userXGrid/3 * 2, 0, userYGrid);
            Rectangle letterURec2 = new Rectangle(userXGrid / 3 + thickness, userXGrid / 3 * 2 - thickness, thickness, userYGrid);
            Difference letterU = new Difference(letterURec1, letterURec2);


            // letter M

            Rectangle letterMRec1 = new Rectangle(userXGrid / 3 * 2, userXGrid / 3 * 2 + thickness, 0, userYGrid);
            Circle letterMCirc1 = new Circle(userXGrid * 5 / 6, userYGrid, userYGrid / 3);
            Circle letterMCirc2 = new Circle(userXGrid*5/6, userYGrid, userYGrid/3 - thickness);
            Difference LetterMDiff = new Difference(letterMCirc1, letterMCirc2 );
            Rectangle letterMRec3 = new Rectangle(userXGrid - thickness, userXGrid, 0, userYGrid);
            Union letterM = new Union(LetterMDiff , letterMRec3);
            Union letterM_Final= new Union(letterM , letterMRec1);

            // letters TU
            Union lettersTU = new Union(letterT, letterU);

            // letters TUM
            Union logoTUM = new Union(lettersTU, letterM_Final);
            logoTUM.Visualize(userXGrid, userYGrid);
            
            //Union lettersTU = new Union(letterT, letterU);
            //lettersTU.Visualize(userXGrid, userYGrid);
        }
    }
}
