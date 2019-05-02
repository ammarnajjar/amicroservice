using Microsoft.AspNetCore.Http;
using amicroservice.Models;

namespace amicroservice.Services
{
    public class UsersRepository
    {
        private const string CacheKey = "UserStore";

        public UsersRepository()
        {
        }

        public User[] AllUsers
        {
            get
            {
                User user1 = new User { Id = 1, name = "first" };
                User user2 = new User { Id = 2, name = "second" };

                return new User[] { user1, user2 };
            }
        }
    }
}
