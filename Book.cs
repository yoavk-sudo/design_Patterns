using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_Patterns
{
    public enum Genres
    {
        Horror,
        Educational,
        Fantasy,
        SciFi,
        NonFiction,
        Romance
    }
    internal class Book
    {
        public string Title { get; set; }
        public string AuthorName { get; set; }
        public DateTime ReleaseDate { get; set; }
        public List<Genres> Genres { get; set; }
        public override string ToString()
        {
            return $"The Title of this book is: {Title}\n" +
                $"The author of this book is: {AuthorName}\n" +
                $"The release date of this book is: {ReleaseDate}\n" +
                $"Its main genre is: {Genres[0]}";
        }
    }
}
