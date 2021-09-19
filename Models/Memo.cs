using System.Collections.Generic;

namespace ChromeMemo.Models
{
    public class Memo
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Text { get; set; }

        public Memo(int id, int userId, string text)
        {
            Id = id;
            UserId = userId;
            Text = text;
        }
    }
}