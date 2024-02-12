using System.Text;
using StreamingService.Clients;
using StreamingService.Persistence;

namespace StreamingService.Services
{
    public class MovieService
    {

       private enum MovieTags
        {
            Sensitive,
            Animation,
            Family

        }
        private readonly StreamingClient _streamingClient;
        public MovieService()
        {
            _streamingClient = new StreamingClient();
        }
        public List<string> ShowContentList()
        {
            return MoviesData.Movies.Select(x => x.Key).ToList();
        }

        public bool ShowContent(int age, string movieName)
        {
            if (age < 13)
            {
                if (IsKidsFriendly(movieName))
                {
                    _streamingClient.StartStreaming(movieName);
                    return true;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red; // Set text color to red for warning
                    Console.WriteLine("Age Alert!!!");
                    Console.ResetColor(); // Reset text color to default
                    
                    return false;
                }
            }
            else
            {
                _streamingClient.StartStreaming(movieName);
                return true;
            }
        }

        private bool IsSensitive(string movieTag)
        {
            return movieTag == MovieTags.Sensitive.ToString();
        }


        private void SetStar(string movieName)
        {
        }

        private void AddToFavorite(string movieName)
        {
        }


        ///// <summary>
        ///// ShowKidsMovies
        ///// </summary>
        ///// <returns></returns>
        //private List<string> ShowKidsMovies()
        //{
        //    return MoviesData.Movies.Where(x => x.Value != "Sensitive").Select(x => x.Key).ToList();
        //}


        /// <summary>
        /// KidsFriendly
        /// </summary>
        /// <param name="movieName"></param>
        /// <returns></returns>
        private bool IsKidsFriendly(string movieName)
        {
            var movieTag = MoviesData.Movies
                .Where(x => x.Key == movieName)
                .Select(x => x.Value).FirstOrDefault();

            return !IsSensitive(movieTag);
        }
    }
}
