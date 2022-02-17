using System;
using System.Threading.Tasks;
using CafIO.Business.Models;

namespace CafIO.Business.Intefaces
{
    public interface IEnderecoRepository : IRepository<Endereco>
    {
        Task<Endereco> ObterEnderecoPorFornecedor(Guid fornecedorId);
    }
}