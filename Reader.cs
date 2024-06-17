using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_Patterns
{
    internal class Reader : IPerson
    {
        private bool _isAlive = true;
        public Genres FavoriteGenre { get; set; }
        public string FavoriteAuthor { get; set; }
        public string Name { get ; set ; }

        public override string ToString()
        {
            return Name;
        }

        public bool IsAlive()
        {
            return _isAlive;
        }

        public bool WillEnjoyBook(Book book)
        {
            if(!IsAlive()) return false;
            if(FavoriteAuthor == null || book.AuthorName == null) return false;
            if(FavoriteAuthor == book.AuthorName)
                return true;
            if(book.Genres == null)
            {
                return false;
            }
            foreach (var genre in book.Genres)
            {
                if(FavoriteGenre == genre)
                    return true;
            }
            return false;
        }
    }
}
