using ChallengeItau.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengeItau.Services
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly ICollection<IPropertyValidator> _validators;

        public AuthenticationService(ICollection<IPropertyValidator> validators)
        {
            this._validators = validators;
        }

        public bool IsValid(string password)
        {
            if (!this._validators.Any())
                throw new ArgumentException("Não foi encontrado validações a serem feitas.");

            foreach (var validator in this._validators)
            {
                if (!validator.IsValid(password))
                    // Aqui teriamos logs de qual validator está sendo ativado
                    return false;
            }

            return true;
        }

        public void Dispose()
        {
            if (this._validators != null)
                this._validators.Clear();
        }
    }
}
