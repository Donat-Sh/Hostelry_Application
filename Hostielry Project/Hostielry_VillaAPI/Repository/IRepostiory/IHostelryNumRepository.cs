using HostelryAPI.APIModels.VM;
using HostelryAPI.Repository.GenericRepo;

namespace MagicVilla_VillaAPI.Repository.IRepostiory
{
    public interface IHostelryNumRepository : IGenericRepository<VillaNumber>
    {
        Task<VillaNumber> UpdateAsync(VillaNumber entity);
    }
}
