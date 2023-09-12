using DesignPatternArchitecture.Application.Persistence.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternArchitecture.Application.Persistence
{
    public interface IUnitOfWork : IDisposable
    {
        IAlunoRepository AlunoRepository { get; }
        ICursoRepository CursoRepository { get; }
        Task Save();
    }
}
