using StreamingService.Services;

namespace StreamingService;

class Program
{
    static void Main()
    {

        var authenticationService = new AuthenticationService();
        var ageService = new AgeService();
        var movieService = new MovieService();
        Console.WriteLine("Enter User: ");
        var user = Console.ReadLine();
        Console.WriteLine("Enter Password: ");
        var password = Console.ReadLine();
        //var user = "user1";
        //var password = "password1";

        var isAuthenticateUser = authenticationService.AuthenticateUser(user, password);
        do
        {
            if (isAuthenticateUser)
            {
                Console.WriteLine($"--------Welcome {user} ---------");
                var list = movieService.ShowContentList();
                foreach (var movie in list)
                {
                    Console.WriteLine(movie);
                }
                Console.WriteLine("-----------------------");
                Console.WriteLine("Enter a movie name: ");
                var movieName = Console.ReadLine();
                var age = ageService.CalculateAge(user);

                movieService.ShowContent(age, movieName);

            }
            else
            {
                Console.WriteLine("--------Access Denied!!!!!! ---------");
            }

            Console.WriteLine("-----------------------");
            Console.WriteLine("-----------------------");
            Console.ReadKey();
        } while (true);
    }

}