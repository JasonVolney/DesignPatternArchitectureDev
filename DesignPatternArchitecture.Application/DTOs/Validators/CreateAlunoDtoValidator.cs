using DesignPatternArchitecture.Application.DTOs.Aluno;
using FluentValidation;

namespace DesignPatternArchitecture.Application.DTOs.Validators
{
    public class CreateAlunoDtoValidator : AbstractValidator<CreateAlunoDto>
    {
        public CreateAlunoDtoValidator()
        {
            Include(new IAlunoDtoValidator());
        }
    }
}
