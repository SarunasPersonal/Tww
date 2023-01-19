using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tww
{
    internal class Item
    {
        public string ItemId { get; set; }
        public string Title { get; set; }
        public string  Type { get; set; }

        public Item(string itemId, string title, string type)
        {
            ItemId = itemId;
            Title = title;
            Type = type;
        }

        public override string? ToString()
        {
            return $"Item Id: {ItemId}\nItem Title: {Title}\nItem Type:{Type}";
        }
    }
}
