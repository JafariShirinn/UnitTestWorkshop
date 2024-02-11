namespace StreamingService.Services;

public class AuthenticationService

{
    readonly Dictionary<string, string> _userPasswords = new Dictionary<string, string>();
    public AuthenticationService()
    {
        _userPasswords["user1"] = "password1";
        _userPasswords["user2"] = "password2";
        _userPasswords["user3"] = "password3";
    }


    public bool AuthenticateUser(string username, string password)
    {
        if (_userPasswords.ContainsKey(username))
        {
            string storedPassword = _userPasswords[username];
            return password == storedPassword;
        }

        // Username not found
        return false;
    }
}
