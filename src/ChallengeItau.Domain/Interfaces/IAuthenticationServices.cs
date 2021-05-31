using System;
using System.Collections.Generic;
using System.Text;

namespace ChallengeItau.Domain.Interfaces
{
    public interface IAuthenticationServices : IDisposable
    {
        bool ValidatePassword(string password);
    }
}
