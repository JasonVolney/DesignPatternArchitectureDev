using DesignPatternArchitecture.Domain.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternArchitecture.Domain.Models
{
    public class Aluno : Base
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Celular { get; set; }
        public string Telefone { get; set; } = string.Empty;
        public string Matricula { get; set; }

    }
}
