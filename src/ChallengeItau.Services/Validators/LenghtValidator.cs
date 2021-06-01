using ChallengeItau.Domain.Interfaces;

namespace ChallengeItau.Services.Validators
{
    public class LenghtValidator : IPropertyValidator
    {
        public bool IsValid(string input)
        {
            return input.Length >= 9;
        }
    }
}
