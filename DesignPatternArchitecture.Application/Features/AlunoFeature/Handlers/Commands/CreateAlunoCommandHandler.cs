using AutoMapper;
using MediatR;
using DesignPatternArchitecture.Application.DTOs.Validators;
using DesignPatternArchitecture.Application.Persistence;
using DesignPatternArchitecture.Application.Responses;
using DesignPatternArchitecture.Application.Features.AlunoFeature.Requests.Commands;

namespace DesignPatternArchitecture.Application.Features.AlunoFeature.Handlers.Commands
{
    public class CreateAlunoCommandHandler : IRequestHandler<CreateAlunoCommand, BaseCommandResponse>
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;

        public CreateAlunoCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<BaseCommandResponse> Handle(CreateAlunoCommand request, CancellationToken cancellationToken)
        {
            var response = new BaseCommandResponse();
            var validator = new CreateAlunoDtoValidator();
            var validationResult = await validator.ValidateAsync(request.AlunoDto);

            if (validationResult.IsValid == false)
            {
                response.Success = false;
                response.Message = "Creation Failed";
                response.Errors = validationResult.Errors.Select(q => q.ErrorMessage).ToList();
            }
            else
            {
                var aluno = _mapper.Map<Domain.Models.Aluno>(request.AlunoDto);

                aluno = await _unitOfWork.AlunoRepository.Add(aluno);
                await _unitOfWork.Save();

                response.Success = true;
                response.Message = "Creation Successful";
                response.Id = aluno.Id;
            }
            return response;
        }
    }
}
