
using System.Reflection;

namespace CompositeDesignPatternFileFolderHierarchyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var movies = new Models.Folder("Movies");

            var actionMovies = new Models.Folder("Action Movies");
            actionMovies.Add(new Models.File("Avesham"));
            actionMovies.Add(new Models.File("Ghajini"));

            var thrillerMovies = new Models.Folder("Thriller Movies");
            thrillerMovies.Add(new Models.File("Inception"));
            thrillerMovies.Add(new Models.File("Shutter Island"));

            var horrorMovies = new Models.Folder("Horror Movies");
            horrorMovies.Add(new Models.File("The Conjuring"));
            horrorMovies.Add(new Models.File("The NUN"));

            movies.Add(actionMovies);
            movies.Add(thrillerMovies);
            movies.Add(horrorMovies);


            List<string> results = new List<string>();
            movies.Display(results, 0);

            foreach (var line in results)
            {
                Console.WriteLine(line);
            }
        }
    }
}