using ChromeMemo.Models;
using System.Collections.Generic;
using System.Linq;

namespace ChromeMemo.Services
{
    public static class MemoService
    {
        static List<Memo> Memos { get; }
        static int nextId = 2;

        static MemoService()
        {
            Memos = new List<Memo>();

            Memos.Add(new Memo(1, 1, "안녕하세요"));
        }

        public static Memo Get(int id) => Memos.FirstOrDefault(m => m.Id == id);

        public static int Add(string name)
        {
            int userId = nextUserId++;
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