using AutoMapper;
using MediatR;
using DesignPatternArchitecture.Application.DTOs.Aluno;
using DesignPatternArchitecture.Application.Persistence.Contracts;
using DesignPatternArchitecture.Application.Features.AlunoFeature.Requests.Queries;

namespace DesignPatternArchitecture.Application.Features.AlunoFeature.Handlers.Queries
{
    public class GetAlunoListRequestHandler : IRequestHandler<GetAlunoListRequest, List<AlunoDto>>
    {
        private readonly IAlunoRepository _alunoRepository;
        private readonly IMapper _mapper;

        public GetAlunoListRequestHandler(IAlunoRepository alunoRepository, IMapper mapper)
        {
            _alunoRepository = alunoRepository;
            _mapper = mapper;
        }
        public async Task<List<AlunoDto>> Handle(GetAlunoListRequest request, CancellationToken cancellationToken)
        {
            var aluno = await _alunoRepository.GetAll();
            return _mapper.Map<List<AlunoDto>>(aluno);
        }
    }
}
