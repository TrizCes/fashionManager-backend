using fashionManager.Dto.Companies.Request;
using fashionManager.Dto.Companies.Response;

namespace fashionManager.Interfaces.Services
{
    public interface ICompaniesService
    {
        Task<CompaniesResponse> CreateAsync(PostCompanies company);
        Task<CompaniesResponse> UpdateAsync(int id, PutCompanies company);
        Task<bool> DeleteAsync(int id);
        Task<CompaniesResponse> GetByIdAsync(int id);
    }
}
