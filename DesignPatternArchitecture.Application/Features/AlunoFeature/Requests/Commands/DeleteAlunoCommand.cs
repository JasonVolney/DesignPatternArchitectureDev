using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternArchitecture.Application.Features.AlunoFeature.Requests.Commands
{
    public class DeleteAlunoCommand : IRequest
    {
        public int Id { get; set; }
    }
}
