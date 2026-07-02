using ClassLibrary.Classes;
using ClassLibrary.Data;
using ClassLibrary.Services;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            var userRepository = new UserRepository();
            var userFactory = new UserFactory();
            var autonificationService = new AuthenticationService(userRepository);
            
            userRepository.AddUser(userFactory.CreateCostumer("Anna", "anna@gmail.com", "iamanna"));
            userRepository.AddUser(userFactory.CreateCostumer("Kate", "kate@gmail.com", "iamkate"));
            userRepository.AddUser(userFactory.CreateCostumer("Sofia", "sofy@gmail.com", "123"));


            User? user = autonificationService.Login("anna@gmail.com", "iamanna");
            Console.WriteLine($"Its {user.Name}");

            user = autonificationService.Login("kate@gmail.com", "iamkate");
            Console.WriteLine($"Its {user.Name}");

            user = autonificationService.Login("sofy@gmail.com", "123");
            Console.WriteLine($"Its {user.Name}");
        }
    }
}
