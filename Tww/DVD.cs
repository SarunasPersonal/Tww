using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tww
{
    internal class DVD : Item
    {
        public string MovieGenre { get; set; }
        public string Director { get; set; }
        public int TotalLength { get; set; }
    }
}
