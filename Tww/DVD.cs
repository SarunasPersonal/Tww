using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tww
{
    //DVD class inherits from Item class
    internal class DVD : Item
    {
        public string MovieGenre { get; set; }
        public string Director { get; set; }
        public int TotalLength { get; set; }
        public DVD(int itemId, string title, string type, string movieGenre, string director, int totalLength) : base(
            itemId, title, type)
        {
            MovieGenre = movieGenre;
            Director = director;
            TotalLength = totalLength;
        }
        
    }
}
