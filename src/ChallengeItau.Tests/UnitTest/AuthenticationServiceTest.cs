using ChallengeItau.Domain.Interfaces;
using ChallengeItau.Services;
using Moq;
using System;
using System.Collections.Generic;
using Xunit;

namespace ChallengeItau.Tests.UnitTest
{
    public class AuthenticationServiceTest
    {
        private AuthenticationService _authenticationService;

        [Fact]
        public void ValidateAuthenticationService_PropertyValidationTrue()
        {
            var mock = new Mock<IPropertyValidator>();
            mock.Setup(m => m.IsValid(It.IsAny<string>())).Returns(true);

            this._authenticationService = new AuthenticationService
            (
                new List<IPropertyValidator>
                {
                    mock.Object
                }
            );

            Assert.True(_authenticationService.IsValid(string.Empty));
        }

        [Fact]
        public void ValidateAuthenticationService_PropertyValidationFalse()
        {
            var mock = new Mock<IPropertyValidator>();
            mock.Setup(m => m.IsValid(It.IsAny<string>())).Returns(false);

            this._authenticationService = new AuthenticationService
            (
                new List<IPropertyValidator>
                {
                    mock.Object
                }
            );

            Assert.False(_authenticationService.IsValid(string.Empty));
        }

        [Fact]
        public void ValidateAuthenticationService_PropertyValidationException()
        {
            this._authenticationService = new AuthenticationService
            (
                new List<IPropertyValidator>
                { }
            );

            Assert.Throws<ArgumentException>(() => _authenticationService.IsValid(string.Empty));
        }
    }
}
