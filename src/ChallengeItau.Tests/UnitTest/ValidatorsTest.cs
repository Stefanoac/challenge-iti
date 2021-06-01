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

        [Fact]
        public void ValidatorTest_LenghtValidatorSuccess()
        {
            var validator = new LengthValidator();
            Assert.True(validator.IsValid("AbTp9!fok"));
        }

        [Fact]
        public void ValidatorTest_LenghtValidatorError()
        {
            var validator = new LengthValidator();
            Assert.False(validator.IsValid("AbTp9!fo"));
        }

        [Fact]
        public void ValidatorTest_DigitValidatorSuccess()
        {
            var validator = new DigitValidator();
            Assert.True(validator.IsValid("AbTp9!fok"));
        }

        [Fact]
        public void ValidatorTest_DigitValidatorError()
        {
            var validator = new DigitValidator();
            Assert.False(validator.IsValid("aaaaaaaaa"));
        }

        [Fact]
        public void ValidatorTest_UpperCaseValidatorSuccess()
        {
            var validator = new UpperCaseValidator();
            Assert.True(validator.IsValid("AbTp9!fok"));
        }

        [Fact]
        public void ValidatorTest_UpperCaseValidatorError()
        {
            var validator = new UpperCaseValidator();
            Assert.False(validator.IsValid("aaaaaaaaa"));
        }

        [Fact]
        public void ValidatorTest_LowerCaseValidatorSuccess()
        {
            var validator = new LowerCaseValidator();
            Assert.True(validator.IsValid("AbTp9!fok"));
        }

        [Fact]
        public void ValidatorTest_LowerCaseValidatorError()
        {
            var validator = new LowerCaseValidator();
            Assert.False(validator.IsValid("AAAAAAAAA"));
        }

        [Fact]
        public void ValidatorTest_SpecialCharactersValidatorSuccess()
        {
            var validator = new SpecialCharactersValidator();
            Assert.True(validator.IsValid("AbTp9!fok"));
        }

        [Fact]
        public void ValidatorTest_SpecialCharactersValidatorError()
        {
            var validator = new SpecialCharactersValidator();
            Assert.False(validator.IsValid("AbTp9ifok"));
        }

        [Fact]
        public void ValidatorTest_RepeatedLetterValidatorSuccess()
        {
            var validator = new RepeatedLetterValidator();
            Assert.True(validator.IsValid("AbTp9!fok"));
        }

        [Fact]
        public void ValidatorTest_RepeatedLetterValidatorError()
        {
            var validator = new RepeatedLetterValidator();
            Assert.False(validator.IsValid("AAAbbbCc"));
        }
    }
}
