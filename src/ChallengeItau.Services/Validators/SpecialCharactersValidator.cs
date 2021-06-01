using ChallengeItau.Domain.Interfaces;
using System.Linq;
using System.Text.RegularExpressions;

namespace ChallengeItau.Services.Validators
{
    public class SpecialCharactersValidator : IPropertyValidator
    {
        public bool IsValid(string input)
        {
            return input.Any(c => !char.IsLetterOrDigit(c) && !char.IsWhiteSpace(c));
        }
    }
}
