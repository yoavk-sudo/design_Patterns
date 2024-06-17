using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_Patterns
{
    internal class BookBuilder
    {
        private readonly Book _book = new Book();
        public BookBuilder AddTitle(string title)
        {
            _book.Title = title;
            return this;
        }
        public BookBuilder AddAuthor(string authorName)
        {
            _book.AuthorName = authorName;
            return this;
        }
        public BookBuilder AddReleaseDate(DateTime releaseDate)
        {
            _book.ReleaseDate = releaseDate;
            return this;
        }
        public BookBuilder AddGenre(Genres genre)
        {
            if(_book.Genres == null)
            {
                _book.Genres = new List<Genres>();
            }
            _book.Genres.Add(genre);
            return this;
        }

        public Book Build() 
        {
            return _book;
        }
    }
}
