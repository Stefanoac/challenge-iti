using ChallengeItau.Domain.Interfaces;

namespace ChallengeItau.Services
{
    public class AuthenticationServices : IAuthenticationServices
    {
        public bool ValidatePassword(string password)
        {
            return true;
        }

        public void Dispose()
        {
            throw new System.NotImplementedException();
        }
    }
}
