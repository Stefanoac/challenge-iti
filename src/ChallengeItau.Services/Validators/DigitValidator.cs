using ChallengeItau.Domain.Interfaces;
using System.Linq;
using System.Text.RegularExpressions;

namespace ChallengeItau.Services.Validators
{
    public class DigitValidator : IPropertyValidator
    {
        public bool IsValid(string input)
        {
            return input.Any(char.IsDigit);
        }
    }
}
