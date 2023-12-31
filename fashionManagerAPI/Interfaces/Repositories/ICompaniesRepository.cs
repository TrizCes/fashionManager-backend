﻿using fashionManager.Dto.Companies.Request;
using fashionManager.Models;

namespace fashionManager.Interfaces.Repositories
{
    public interface ICompaniesRepository
    {
        Task<bool> CheckUser(int id, string email);
        Task<bool> CreateAsync(Company company);
        Task<Company?> UpdateAsync(int id, PutCompanies company);
        Task<bool> DeleteAsync(int id);
        Task<Company> GetByIdAsync(int id);
        Task<bool> CheckEmailAsync(int id, string email);
        Task<bool> CheckCnpjAsync(int id, string cnpj);
    }
}
