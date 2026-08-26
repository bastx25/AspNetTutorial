using api.Models;

namespace api.Interfaces
{
    public interface IPortfolioRepository
    {
        Task<Portfolio?> DeletePortfolioAsync(AppUser user, string symbol);
        Task<Portfolio> CreateAsync(Portfolio portfolioModel);
        Task<List<Stock>> GetUserPortfolioAsync(AppUser user);
    }
}
