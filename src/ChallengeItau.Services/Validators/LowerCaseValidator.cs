using ChallengeItau.Domain.Interfaces;
using System.Linq;

namespace ChallengeItau.Services.Validators
{
    public class LowerCaseValidator : IPropertyValidator
    {
        public bool IsValid(string input)
        {
            return input.Any(char.IsLower);
        }
    }
}
