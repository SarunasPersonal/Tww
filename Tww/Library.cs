using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tww
{
    internal class Library
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public List<Item> Items { get; set; }
        public Library(string name, string address)
        {
            Name = name;
            Address = address;
            Items = new List<Item>();
        }

        public Item? GeItem(string itemNumber)
        {
            foreach (var item in Items)
            {
                if (item.ItemId == itemNumber)
                {
                    return item;
                }
            }

            return null;
            }
        }
    }


