using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WhiteIO.App.ViewModels;

namespace WhiteIO.App.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<WhiteIO.App.ViewModels.ProdutoViewModel>? ProdutoViewModel { get; set; }
    }
}