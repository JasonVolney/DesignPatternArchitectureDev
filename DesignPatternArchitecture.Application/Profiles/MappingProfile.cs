using AutoMapper;
using DesignPatternArchitecture.Application.DTOs.Aluno;
using DesignPatternArchitecture.Application.DTOs.Curso;
using DesignPatternArchitecture.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternArchitecture.Application.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Aluno, AlunoDto>().ReverseMap();
            CreateMap<Curso, CursoDto>().ReverseMap();
            CreateMap<AlunoDto, Aluno>();
            CreateMap<CursoDto, Curso>();
        }
    }
}
