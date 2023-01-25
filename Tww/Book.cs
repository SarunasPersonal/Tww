using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tww
{

    internal class Book : Item

    {
        public string Author { get; set; }
        public string LiteraryGenre { get; set; }
        public int Pages { get; set; }

        public Book(int itemId, string title, string type, string author, string literaryGenre, int pages) : base(
            itemId, title, type)
        {
            Author = author;
            LiteraryGenre = literaryGenre;
            Pages = pages;
        }

        public override string ToString()
        {
            return $"Item ID: {ItemId}, Title: {Title}, Type: {Type}, Author: {Author}, Literary Genre: {LiteraryGenre}, Pages: {Pages}";
        }

    }
}

    