using DesignPatternArchitecture.Application.DTOs.Aluno;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternArchitecture.Application.Features.AlunoFeature.Requests.Commands
{
    public class UpdateAlunoCommand : IRequest<Unit>
    {
        public AlunoDto AlunoDto { get; set; }
    }
}
