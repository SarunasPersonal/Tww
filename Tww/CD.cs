using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tww
{
    internal class CD : Item
    {
        public string Artist { get; set; }
        public string Genre  { get; set; }
        public int Tracks { get; set; }
    }
}
