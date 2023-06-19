using WhiteIO.Bussines.Models;

namespace WhiteIO.Business.Interfaces
{
    public interface IEnderecoRepository
    {
        Task<Endereco> ObterEnderecoPorFornecedor(Guid fornecedorId);
    }
}
