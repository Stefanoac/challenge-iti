using ChallengeItau.Domain.Interfaces;
using System.Linq;
using System.Text.RegularExpressions;

namespace ChallengeItau.Services.Validators
{
    public class RepeatedLetterValidator : IPropertyValidator
    {
        public bool IsValid(string input)
        {
            var regex = new Regex(@"(\w)*.*\1");
            return !regex.IsMatch(input);
        }
    }
}
