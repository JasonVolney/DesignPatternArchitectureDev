using DesignPatternArchitecture.Application.DTOs.Aluno;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternArchitecture.Application.DTOs.Validators
{
    public class IAlunoDtoValidator : AbstractValidator<IAlunoDto>
    {
        public IAlunoDtoValidator()
        {
            RuleFor(p => p.Email)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .NotNull()
                .MaximumLength(50).WithMessage("{PropertyName} must not exceed {ComparisonValue} characters.");

            RuleFor(p => p.Telefone)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .NotNull()
                .MaximumLength(11).WithMessage("{PropertyName} must not exceed {ComparisonValue} characters.");
        }
    }
}
