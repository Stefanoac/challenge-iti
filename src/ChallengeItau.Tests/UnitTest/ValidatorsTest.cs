using ChallengeItau.Services.Validators;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ChallengeItau.Tests.UnitTest
{
    public class ValidatorsTest
    {
        [Fact]
        public void ValidatorTest_NullPropertyValidatorSuccess()
        {
            var validator = new NullPropertyValidator();
            Assert.True(validator.IsValid("AbTp9!fok"));
        }

        [Fact]
        public void ValidatorTest_NullPropertyValidatorError()
        {
            var validator = new NullPropertyValidator();
            Assert.False(validator.IsValid(string.Empty));
        }
    }
}
