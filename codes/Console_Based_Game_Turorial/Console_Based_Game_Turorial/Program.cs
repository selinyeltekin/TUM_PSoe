using System;



    using Console_Based_Game_Turorial;

    public class Program
    {
        public const int SizeX = 32;   //it is a constant and its not gonna change
        public const int SizeY = 32;
    private static Tile[,] tiles;

    public static void Main(string[] args)
        {
        /*
        //string line = "Hello World!";

        //helps us to write multiple line codes
        string[] lines = new string[] { "Hello World!", "Ayse", "Selin" };

        /* lines[0] = "hello world!";
         lines[1] = "ask";
         lines[2] = "hi"; */

        //there must be an easier way

        /*Console.WriteLine(lines[0]);
        Console.WriteLine(lines[1]);
        Console.WriteLine(lines[2]);*/

        /*
        int i = 0;
        foreach (string line in lines)
        {
            Console.WriteLine(line);
            i++;
        }

    


        int k = 0;
        while (k < lines.Length)  //this will run forever
        {
            Console.WriteLine($"[{k}]: {lines[k]}");
            k++;
        }


        bool success;    //true or false

        do
        {
            success = true;

        }
        while (!success);    // it will keep running since it hits false

        */

        //-----------STARTING TO CREATE THE GAME    

        Tile[][] tiles = new Tile[SizeX][];

            Draw();    //calling the method
            
           
        }
        //creating method to draw a square
        public static void Draw()
        {
            //Drawing and Written for the entire grid
            for (int y = SizeY; y > 0; y--)      //drawing a single line by dots
            {
                for (int x=0; x<SizeX; x++)  
                {
                TileTypes.Grass.Render();
         
                }
            
            SetupNextLine();

            }
        }

    public static void SetupNextLine()
    {
        
                //This prevents green from leaking to the rigth
                 Console.BackgroundColor = ConsoleColor.Black;
                 Console.ForegroundColor = ConsoleColor.Black;
                 Console.Write(".");

                 //Shifts to the next line
                 Console.Write('\n');
    }
    }

