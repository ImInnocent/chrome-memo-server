using ChromeMemo.Models;
using System.Collections.Generic;
using System.Linq;

namespace ChromeMemo.Services
{
    public static class UserService
    {
        static List<UserInfo> Users { get; }
        static int nextId = 2;

        static UserService()
        {
            Users = new List<UserInfo>();

            Users.Add(new UserInfo(1, "Inho"));
        }

        public static UserInfo Get(int id) => Users.FirstOrDefault(m => m.UserId == id);

        public static int Add(string name)
        {
            int userId = nextId++;
            Users.Add(new UserInfo(userId, name));

            return userId;
        }

        public static void Update(UserInfo user)
        {
            var index = Users.FindIndex(m => m.UserId == user.UserId);
            if(index == -1)
                return;

            Users[index] = user;
        }
    }
}