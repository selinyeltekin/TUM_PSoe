using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Based_Game_Turorial
{
    public class Tile
    {

    }

    public static class TileTypes
    {
        public static readonly TileType Air;
        public static readonly TileType Grass;
        public static readonly TileType Wood;
        public static readonly TileType Water;
        static TileTypes()
        {
            Air = new TileType("Air", ConsoleColor.Cyan, ConsoleColor.Black, " ");
            Grass = new TileType("Grass", ConsoleColor.DarkGreen, ConsoleColor.Green, "##");
            Wood = new TileType("Wood", ConsoleColor.DarkRed, ConsoleColor.Black, "||");
            Water = new TileType("Water", ConsoleColor.Blue, ConsoleColor.Cyan, "@");
        }
    }

    public class TileType
    {
        //properties
        public string Name { get; set; }

        public ConsoleColor BackColor { get; set; }

        public ConsoleColor ForeColor { get; set; }
        public string RenderString { get; set; }

        //Constructor is a special method for onject creation
        public TileType(string name, ConsoleColor backColor, ConsoleColor foreColor, string renderString)
        {
            this.Name = name;
            this.BackColor = backColor;
            this.ForeColor = foreColor;
            this.RenderString = renderString;

        }

        //method
        public void Render ()
        {
            //To color the background and fore
            Console.BackgroundColor = BackColor;
            Console.ForegroundColor = ForeColor;
            Console.Write(RenderString);
        }
    }
}
