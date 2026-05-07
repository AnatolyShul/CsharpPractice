using System.Runtime.ConstrainedExecution;
using System.Xml.Serialization;
using Microsoft.VisualBasic;

namespace XMLinClass
{
    public class Movie
    {
        private string _name;
        private int _duration;
        private int[] _rewiev;
        public string Name => _name;
        public int Duration => _duration;
        public int[] Rewiev => _rewiev.ToArray();

        public Movie(string name, int duration)
        {
            _name = name;
            _duration = duration;
            _rewiev = new int[0];
        }
        public void AddRewiev(int stars)
        {
            Array.Resize(ref _rewiev, _rewiev.Length + 1);
            _rewiev[_rewiev.Length - 1] = stars;
        }
    }

    public class MovieDTO
    {
        //свойства с публичными сеттерами
        public string MovieType { get; set; }
        public string Name { get; set; }
        public int Duration { get; set; }
        public int[] Rewiev { get; set; }

        //конструктор без параметров
        public MovieDTO() { }

        //Movie -> MovieDTO

        public MovieDTO(string name, int duration, int[] rewiev)
        {
            MovieType = nameof(Movie);
            Name = name;
            Duration = duration;
            Rewiev = rewiev;
        }

        public MovieDTO(Movie movie)
        {
            MovieType = movie.GetType().Name;
            Name = movie.Name;
            Duration = movie.Duration;
            Rewiev = movie.Rewiev;
        }
    }

    internal class Program
    {
        static void Main()
        {
            //объект для сериализации
            Movie movie1 = new Movie("Harry Poter", 120);
            movie1.AddRewiev(5);
            movie1.AddRewiev(3);
            movie1.AddRewiev(4);
            movie1.AddRewiev(5);

            MovieDTO movieDTO1 = new MovieDTO(movie1);
            string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string filePath = Path.Combine(folderPath, "movie.xml");

            var serializer = new XmlSerializer(typeof(MovieDTO));
            //сериализация
            using (var writer = new StreamWriter(filePath))
            {
                serializer.Serialize(writer, movieDTO1);
            }
            //десериализация
            MovieDTO movieDTO2;
            using (var reader = new StreamReader(filePath))
            {
                movieDTO2 = (MovieDTO)serializer.Deserialize(reader);
            }

            Movie movie2 = new Movie(movieDTO2.Name, movieDTO2.Duration);
            foreach (int star in movieDTO2.Rewiev)
            {
                movie2.AddRewiev(star);
            }

            if (CompareMovies(movie1, movie2))
            {
                System.Console.WriteLine("Succes");
            }
            else
            {
                System.Console.WriteLine("Not compare");
            }
        }

        public static bool CompareMovies(Movie m1, Movie m2)
        {
            if (m1.Name != m2.Name || m1.Duration != m2.Duration || m1.Rewiev.Length != m2.Rewiev.Length)
            {
                return false;
            }
            for (int i = 0; i < m1.Rewiev.Length; i++)
            {
                if (m1.Rewiev[i] != m2.Rewiev[i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
