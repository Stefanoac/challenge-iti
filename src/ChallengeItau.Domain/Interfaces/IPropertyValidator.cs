using System;
using System.Collections.Generic;
using System.Text;

namespace ChallengeItau.Domain.Interfaces
{
    public interface IPropertyValidator
    {
        bool IsValid(string input);
    }
}
