using api.Models;

namespace api.Interfaces
{
    public interface IPortfolioRepository
    {
        Task<Portfolio> CreateAsync(Portfolio portfolioModel);
        Task<List<Stock>> GetUserPortfolioAsync(AppUser user);
    }
}
