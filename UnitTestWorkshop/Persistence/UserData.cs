namespace StreamingService.Persistence
{
    public static class UserData
    {
        public static readonly Dictionary<string, string> UserPasswords = new Dictionary<string, string>
        {
            {"user1","password1"},
            {"user2","password2"},
            {"user3","password3"}
        };

        public static readonly Dictionary<string, int> UserAge = new Dictionary<string, int>
        {
            {"user1",10},
            {"user2",19},
            {"user3",30}
        };
    }
}
