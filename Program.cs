namespace design_Patterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string title = "Design Patterns of Trolls";
            string author = "Yoav Kendler";
            DateTime releaseDate = DateTime.Now;
            List<Genres> genres = [Genres.Educational, Genres.Fantasy, Genres.Romance];
            Person person = Person.Reader;
            string readerName = "Ido";
            string favoriteAuthor = "Erich Gamma";
            Genres favoriteGenre = Genres.Educational;
            Book book = new BookBuilder()
                            .AddTitle(title)
                            .AddAuthor(author)
                            .AddReleaseDate(releaseDate)
                            .AddGenre(genres[0])
                            .AddGenre(genres[1])
                            .AddGenre(genres[2])
                            .Build();
            Console.WriteLine(book.ToString());
            IPerson reader = PersonFactory.Create(person);
            reader.Name = readerName;
            (reader as Reader).FavoriteGenre = favoriteGenre;
            (reader as Reader).FavoriteAuthor = favoriteAuthor;
            Console.WriteLine($"Would {reader} enjoy {book.Title}? {(reader as Reader).WillEnjoyBook(book)}");
        }
    }
}
