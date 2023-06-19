using WhiteIO.Bussines.Models;

namespace WhiteIO.Business.Interfaces
{
    public interface IProdutoRepository : IRepository<Produto>
    {
        Task<IEnumerable<Produto>> ObterProdutosPorFornecedor(Guid fornecedorId);
        Task<IEnumerable<Produto>> ObterProdutosPorFornecedores();
        Task<Produto> ObterProdutoFornecedor(Guid id);

    }
}
