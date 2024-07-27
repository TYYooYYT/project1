namespace MeetingApp.Models
{
    public static class Repository
    {
        private static List<UserInfo> _users = new();

        private static List<UserInfo> Users
        {
            get{
                return _users;
            }
        }

        public static void CreateUser(UserInfo user)
        {
            _users.Add(user);
        }
    }
}