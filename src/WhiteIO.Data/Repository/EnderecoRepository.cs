using Microsoft.EntityFrameworkCore;
using WhiteIO.Business.Interfaces;
using WhiteIO.Bussines.Models;
using WhiteIO.Data.Context;

namespace WhiteIO.Data.Repository
{
    public class EnderecoRepository : Repository<Endereco>, IEnderecoRepository
    {
        public EnderecoRepository(MeuDbContext context) : base(context)
        {
            
        }
        public async Task<Endereco> ObterEnderecoPorFornecedor(Guid fornecedorId)
        {
            return await Db.Enderecos.AsNoTracking().FirstOrDefaultAsync(e => e.FornecedorId == fornecedorId);
        }
    }
}
