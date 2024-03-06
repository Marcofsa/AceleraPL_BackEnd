using ApiAuth.Models;

namespace ApiAuth.Repository
{
    public static class UserRepository
    {
        public static User? Get(string username, string password)
        {
            var users = new List<User>()
            {
                new (){Id = 1 , UserName = "admin" , Password = "admin", Role = "Manager"},
                new (){Id = 2 , UserName = "Shaolin" , Password = "shao", Role = "Client"},
                new (){Id = 3 , UserName = "ChicoDoce" , Password = "doce", Role = "Vendedor"}

            };
            return users.FirstOrDefault(user => username == username && user.Password == password);
        }
    }
}
