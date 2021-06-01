using ChallengeItau.Domain.Interfaces;
using System.Linq;

namespace ChallengeItau.Services.Validators
{
    public class UpperCaseValidator : IPropertyValidator
    {
        public bool IsValid(string input)
        {
            return input.Any(char.IsUpper);
        }
    }
}
