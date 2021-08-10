using ChromeMemo.Models;
using System.Collections.Generic;
using System.Linq;

namespace ChromeMemo.Services
{
    public static class MemoService
    {
        static List<Memo> Memos { get; }
        static int nextUserId = 2;

        static MemoService()
        {
            Memos = new List<Memo>();

            Memos.Add(new Memo(0));
            Memos.Add(new Memo(1));
        }

        public static Memo Get(int id) => Memos.FirstOrDefault(m => m.Id == id);

        public static int Add()
        {
            int userId = nextUserId++;
            Memos.Add(new Memo(userId));

            return userId;
        }

        public static void Update(Memo memo)
        {
            var index = Memos.FindIndex(m => m.Id == memo.Id);
            if(index == -1)
                return;

            Memos[index] = memo;
        }
    }
}