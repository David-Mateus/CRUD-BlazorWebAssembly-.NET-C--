using ToDoCrudBlazor.Models;

namespace ToDoCrudBlazor.Services
{
    public interface ICompanyService
    {
        // criando as assinaturas dos nossos metodos interface
        Task Add(Company company);
        Task Update(Company company);

        Task Delete(Company company);

        Task<Company> GetBy(Guid id);
        Task<List<Company>> FindAll();
    }
}
