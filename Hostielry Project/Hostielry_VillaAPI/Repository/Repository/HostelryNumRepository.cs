using HostelryAPI.APIModels.VM;
using HostelryAPI.Repository.GenericRepo;
using MagicVilla_VillaAPI.Data;
using MagicVilla_VillaAPI.Repository.IRepostiory;

namespace HostelryAPI.Repository.Repository
{
    public class HostelryNumRepository : GenericRepository<VillaNumber>, IHostelryNumRepository
    {
        private readonly ApplicationDbContext _db;
        public HostelryNumRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public async Task<VillaNumber> UpdateAsync(VillaNumber entity)
        {
            entity.UpdatedDate = DateTime.Now;
            _db.VillaNumbers.Update(entity);
            await _db.SaveChangesAsync();
            return entity;
        }
    }
}
