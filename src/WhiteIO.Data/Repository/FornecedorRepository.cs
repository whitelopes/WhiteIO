using Microsoft.EntityFrameworkCore;
using WhiteIO.Business.Interfaces;
using WhiteIO.Bussines.Models;
using WhiteIO.Data.Context;

namespace WhiteIO.Data.Repository
{
    public class FornecedorRepository : Repository<Fornecedor>, IFornecedorRepository
    {
        public FornecedorRepository(MeuDbContext context) : base(context)
        {
        }

        public async Task<Fornecedor> ObterFornecedorEndereco(Guid id)
        {
            return await Db.Fornecedores.AsNoTracking()
                                        .Include(f => f.Endereco)
                                        .FirstOrDefaultAsync(f => f.Id == id);
        }

        public async Task<Fornecedor> ObterFornecedorProdutosEndereco(Guid id)
        {
            return await Db.Fornecedores.AsNoTracking()
                                        .Include(f => f.Produtos)
                                        .Include(f => f.Endereco)
                                        .FirstOrDefaultAsync(f => f.Id == id);
        }
    }
}
