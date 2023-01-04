using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Class_Attributes
{
    internal class Song
    {
        public string title;
        public string artist;
        public int duration;
        public static int songCount = 0;   //is an attribute that is all about the class.

        public Song(string aTitle, string aArtist, int aDuration)
        {
            title = aTitle;
            artist = aArtist;
            duration = aDuration;
            songCount++;  //everytime a song object created its gonna be increased
        }

        //Create a method
        public int getSongCount()
        {
            return songCount;  //we will be able to access the song count on each of individual object
        }
    }
}
