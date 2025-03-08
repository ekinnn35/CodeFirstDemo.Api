namespace CodeFirstDemo.Api.Entities
{
    public class Movie
    {
        public int Id { get; set; }  // Primary Key
        public string Title { get; set; } // Filmin adı
        public string Genre { get; set; } // Türü
        public int ReleaseYear { get; set; } // Çıkış yılı
    }
}
