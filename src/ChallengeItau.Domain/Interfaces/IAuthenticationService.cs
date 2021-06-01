using System;
using System.Collections.Generic;
using System.Text;

namespace ChallengeItau.Domain.Interfaces
{
    public interface IAuthenticationService : IDisposable
    {
        bool IsValid(string password);
    }
}
