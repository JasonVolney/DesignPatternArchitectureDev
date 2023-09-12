using DesignPatternArchitecture.Domain.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternArchitecture.Domain.Models
{
    public class Curso : Base
    {
        public string NmeCurso { get; set; }
        public string Descricao { get; set; }
        public string Codigo { get; set; }

    }
}
