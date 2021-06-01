using ChallengeItau.Domain.Interfaces;
using System;

namespace ChallengeItau.Services.Validators
{
    public class NullPropertyValidator : IPropertyValidator
    {
        public bool IsValid(string input)
        {
            return !string.IsNullOrEmpty(input);
        }
    }
}
