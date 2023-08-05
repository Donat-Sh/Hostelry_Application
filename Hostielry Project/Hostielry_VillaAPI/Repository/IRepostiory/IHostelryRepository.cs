using HostelryAPI.APIModels.VM;
using HostelryAPI.Repository.GenericRepo;

namespace MagicVilla_VillaAPI.Repository.IRepostiory
{
    public interface IHostelryRepository : IGenericRepository<Villa>
    {
        Task<Villa> UpdateAsync(Villa entity);
    }
}
