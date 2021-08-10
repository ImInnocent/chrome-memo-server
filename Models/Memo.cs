using System.Collections.Generic;

namespace ChromeMemo.Models
{
    public class Memo
    {
        public int Id { get; set; }
        public List<string> Memos { get; set; }

        public Memo(int id)
        {
            Id = id;
            Memos = new List<string>();
        }
    }
}