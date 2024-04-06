using System.ComponentModel.DataAnnotations;

namespace WhatInfoApi.Validation
{
    public class ValidaPrimeiraLetraAttribute : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if (value == null || string.IsNullOrEmpty(value.ToString()))
            {
                return ValidationResult.Success;
            }
            var primeiraLetra = value.ToString()[0].ToString();
            if (primeiraLetra != primeiraLetra.ToUpper())
            {
                return new ValidationResult("Primeira letra precisa ser Maiuscula");
            }
            return ValidationResult.Success;
        }
    }
}
