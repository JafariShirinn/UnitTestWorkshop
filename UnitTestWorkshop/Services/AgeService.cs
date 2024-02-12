using StreamingService.Persistence;

namespace StreamingService.Services
{
    public class AgeService
    {
        public int CalculateAge(string user)
        {
            return UserData.UserAge.GetValueOrDefault(user);
        }
    }
}
