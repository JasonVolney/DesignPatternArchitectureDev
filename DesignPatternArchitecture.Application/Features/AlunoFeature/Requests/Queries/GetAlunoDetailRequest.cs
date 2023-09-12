using DesignPatternArchitecture.Application.DTOs.Aluno;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternArchitecture.Application.Features.AlunoFeature.Requests.Queries
{
    public class GetAlunoDetailRequest : IRequest<AlunoDto>
    {
        public int Id { get; set; }
    }
}
