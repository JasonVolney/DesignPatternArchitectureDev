using DesignPatternArchitecture.Application.DTOs.Aluno;
using DesignPatternArchitecture.Application.Responses;
using MediatR;

namespace DesignPatternArchitecture.Application.Features.AlunoFeature.Requests.Commands
{
    public class CreateAlunoCommand : IRequest<BaseCommandResponse>
    {
        public CreateAlunoDto AlunoDto { get; set; }
    }
}
