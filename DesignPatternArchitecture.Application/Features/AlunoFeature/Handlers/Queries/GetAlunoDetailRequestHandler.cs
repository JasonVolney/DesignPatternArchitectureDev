using MediatR;
using AutoMapper;
using DesignPatternArchitecture.Application.DTOs.Aluno;
using DesignPatternArchitecture.Application.Features.AlunoFeature.Requests.Queries;
using DesignPatternArchitecture.Application.Persistence.Contracts;

namespace DesignPatternArchitecture.Application.Features.AlunoFeature.Handlers.Queries
{
    public class GetAlunoDetailRequestHandler : IRequestHandler<GetAlunoDetailRequest, AlunoDto>
    {
        private readonly IAlunoRepository _alunoRepository;
        private readonly IMapper _mapper;

        public GetAlunoDetailRequestHandler(IAlunoRepository alunoRepository, IMapper mapper)
        {
            _alunoRepository = alunoRepository;
            _mapper = mapper;
        }
        public async Task<AlunoDto> Handle(GetAlunoDetailRequest request, CancellationToken cancellationToken)
        {
            var aluno = await _alunoRepository.Get(request.Id);
            return _mapper.Map<AlunoDto>(aluno);
        }
    }
}
;