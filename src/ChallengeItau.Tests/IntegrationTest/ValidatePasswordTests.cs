using ChallengeItau.Domain.Interfaces;
using ChallengeItau.Services;
using ChallengeItau.Services.Validators;
using System.Collections.Generic;
using Xunit;

namespace ChallengeItau.IntegrationTest.Tests
{
    public class ValidatePasswordTests
    {
        [Theory]
        [InlineData("AbTp9!fok")]
        [InlineData("AbTp9!fok@")]
        [InlineData("AbTp9!fok+")]
        [InlineData("AbTp9!fok-")]
        public void ValidatePassword_ReturnTrue(string password)
        {
            var service = SetupAthenticationService();
            Assert.True(service.IsValid(password));
        }

        [Theory]
        [InlineData("")]
        [InlineData("aa")]
        [InlineData("ab")]
        [InlineData("AAAbbbCc")]
        [InlineData("AbTp9!foo")]
        [InlineData("AbTp9!foA")]
        [InlineData("AbTp9 fok")]
        public void ValidatePassword_ReturnFalse(string password)
        {
            var service = SetupAthenticationService();
            Assert.False(service.IsValid(password));
        }


        private AuthenticationService SetupAthenticationService()
        {
            return new AuthenticationService
            (
                new List<IPropertyValidator>
                {
                    new NullPropertyValidator(),
                    new LengthValidator(),
                    new DigitValidator(),
                    new LowerCaseValidator(),
                    new UpperCaseValidator(),
                    new SpecialCharactersValidator(),
                    new RepeatedLetterValidator()
                }
            );
        }
    }
}
