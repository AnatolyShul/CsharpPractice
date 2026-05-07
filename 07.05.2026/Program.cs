using System.Xml.Serialization;

namespace XMLinClass
{
    public class Movie
    {
        private string _name;
        private int _duration;
        public string Name => _name;
        public int Duration => _duration;

        public Movie(string name, int duration)
        {
            _name = name;
            _duration = duration;
        }
    }

    public class MovieDTO
    {
        //свойства с публичными сеттерами
        public string Name{ get; set; }
        public int Duration{ get; set; }

        //конструктор без параметров
        public MovieDTO() { }

        //Movie -> MovieDTO

        public MovieDTO(string name, int duration)
        {
            Name = name;
            Duration = duration;
        }

        public MovieDTO(Movie movie)
        {
            Name = movie.Name;
            Duration = movie.Duration;
        }
    }

    internal class Program
    {
        static void Main()
        {
            Movie movie1 = new("Harry Poter", 120);

            MovieDTO movieDTO1 = new(movie1);
            string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string filePath = Path.Combine(folderPath, "movie.xml");

            var serializer = new XmlSerializer(typeof(MovieDTO));
        }
    }
}
