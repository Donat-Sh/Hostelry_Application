using HostelryAPI.APIModels.VM;
using HostelryAPI.Repository.GenericRepo;
using MagicVilla_VillaAPI.Data;
using MagicVilla_VillaAPI.Repository.IRepostiory;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace HostelryAPI.Repository.Repository
{
    public class HostelryRepository : GenericRepository<Villa>, IHostelryRepository
    {
        private readonly ApplicationDbContext _db;
        public HostelryRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }


        public async Task<Villa> UpdateAsync(Villa entity)
        {
            entity.UpdatedDate = DateTime.Now;
            _db.Villas.Update(entity);
            await _db.SaveChangesAsync();
            return entity;
        }
    }
}
