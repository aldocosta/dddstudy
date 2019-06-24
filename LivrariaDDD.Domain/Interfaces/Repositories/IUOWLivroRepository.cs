using System;
using System.Collections.Generic;
using System.Text;

namespace LivrariaDDD.Domain.Interfaces.Repositories
{
    public interface IUnityOfWork
    {
        ILivroRepository _LivroRepository { get; set; }
        ILivroGeneroRepository _LivroGeneroRepository { get; set; }
        IGeneroRepository _GeneroRepository { get; set; }
        void Commit();
    }
}
