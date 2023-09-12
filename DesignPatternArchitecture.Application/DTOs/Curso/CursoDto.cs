using DesignPatternArchitecture.Application.DTOs.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternArchitecture.Application.DTOs.Curso
{
    public class CursoDto : BaseDto
    {
        public string NmeCurso { get; set; }
        public string Descricao { get; set; }
        public string Codigo { get; set; }
    }
}
