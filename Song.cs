using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learnCsharp
{
    internal class Song
    {
        public string name;
        public string singer;
        public string type;

        public static int songCount; // static means this variable belongs to the Class Song
        public Song(string aName, string aSinger, string aType)
        {
            name = aName;
            singer = aSinger;
            type = aType;
            songCount++;
        }
    }
}
