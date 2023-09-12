using DesignPatternArchitecture.Application.DTOs.Common;

namespace DesignPatternArchitecture.Application.DTOs.Aluno
{
    public class AlunoDto : BaseDto, IAlunoDto
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Celular { get; set; }
        public string Telefone { get; set; } = string.Empty;
        public string Matricula { get; set; }
    }
}
