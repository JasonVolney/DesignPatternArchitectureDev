using AutoMapper;
using DesignPatternArchitecture.Application.Features.AlunoFeature.Requests.Commands;
using DesignPatternArchitecture.Application.Persistence;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternArchitecture.Application.Features.AlunoFeature.Handlers.Commands
{
    public class UpdateAlunoCommandHandler : IRequestHandler<UpdateAlunoCommand, Unit>
    {

        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public UpdateAlunoCommandHandler()
        {

        }
        public Task<Unit> Handle(UpdateAlunoCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
