using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tww
{



//Main class for the All items in the library
    internal class Item
    {
        public int ItemId { get; set; }
        public string Title { get; set; }
        public string Type { get; set; }

        public Item(int itemId, string title, string type)
        {
            ItemId = itemId;
            Title = title;
            Type = type;
        }


    }
}

