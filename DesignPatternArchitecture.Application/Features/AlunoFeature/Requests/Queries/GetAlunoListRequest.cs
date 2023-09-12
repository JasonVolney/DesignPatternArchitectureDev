using MediatR;
using DesignPatternArchitecture.Application.DTOs.Aluno;

namespace DesignPatternArchitecture.Application.Features.AlunoFeature.Requests.Queries
{
    public class GetAlunoListRequest : IRequest<List<AlunoDto>>
    {
    }
}
