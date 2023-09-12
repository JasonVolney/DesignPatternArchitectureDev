using AutoMapper;
using DesignPatternArchitecture.Application.Features.AlunoFeature.Requests.Commands;
using DesignPatternArchitecture.Application.Persistence;
using DesignPatternArchitecture.Domain.Models;
using MediatR;

namespace DesignPatternArchitecture.Application.Features.AlunoFeature.Handlers.Commands
{
    public class DeleteAlunoCommandHandler : IRequestHandler<DeleteAlunoCommand>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public DeleteAlunoCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<Unit> Handle(DeleteAlunoCommand request, CancellationToken cancellationToken)
        {
            var aluno = await _unitOfWork.AlunoRepository.Get(request.Id);

            if(aluno == null)
            {
                throw new NotFoundException(nameof(Aluno), request.Id);
            }
            await _unitOfWork.AlunoRepository.Delete(aluno);
            await _unitOfWork.Save();

            return Unit.Value;
        }
    }
}
