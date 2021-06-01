using ChallengeItau.Domain.Interfaces;

namespace ChallengeItau.Services.Validators
{
    public class LengthValidator : IPropertyValidator
    {
        private const int MINIMUM_LENGTH = 9;

        public bool IsValid(string input)
        {
            return input.Length >= MINIMUM_LENGTH;
        }
    }
}
