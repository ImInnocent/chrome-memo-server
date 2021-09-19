namespace ChromeMemo.Models
{
    public class UserInfo
    {
        public int UserId { get; set; }

        public string Name { get; set; }

        public UserInfo(int userId, string name)
        {
            UserId = userId;
            Name = name;
        }
    }
}