using System;
using System.Threading.Tasks;
using CafIO.Business.Intefaces;
using CafIO.Business.Models;
using CafIO.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace CafIO.Data.Repository
{
    public class EnderecoRepository : Repository<Endereco>, IEnderecoRepository
    {
        public EnderecoRepository(MeuDbContext context) : base(context) { }

        public async Task<Endereco> ObterEnderecoPorFornecedor(Guid fornecedorId)
        {
            return await Db.Enderecos.AsNoTracking()
                .FirstOrDefaultAsync(f => f.FornecedorId == fornecedorId);
        }
    }
}