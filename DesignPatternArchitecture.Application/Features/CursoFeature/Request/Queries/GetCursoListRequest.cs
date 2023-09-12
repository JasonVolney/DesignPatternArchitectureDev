using DesignPatternArchitecture.Application.DTOs.Curso;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternArchitecture.Application.Features.CursoFeature.Request.Queries
{
    public class GetCursoListRequest : IRequest<List<CursoDto>>
    {
    }
}
