using AutoMapper;
using HostelryAPI.APIModels.APIData;
using MagicVilla_VillaAPI.Repository.IRepostiory;
using Microsoft.AspNetCore.Mvc;

namespace HostelryAPI.Controllers.v2
{
    [Route("api/v{version:apiVersion}/VillaNumberAPI")]
    [ApiController]
    [ApiVersion("2.0")]
    public class HostelryNumController : ControllerBase
    {
        protected APIResponse _response;
        private readonly IHostelryNumRepository _dbVillaNumber;
        private readonly IHostelryRepository _dbVilla;
        private readonly IMapper _mapper;

        public HostelryNumController(IHostelryNumRepository dbVillaNumber, IMapper mapper, IHostelryRepository dbVilla)
        {
            _dbVillaNumber = dbVillaNumber;
            _mapper = mapper;
            _response = new();
            _dbVilla = dbVilla;
        }


        //[MapToApiVersion("2.0")]
        [HttpGet("GetString")]
        public IEnumerable<string> Get()
        {
            return new string[] { "Test", "Test2" };
        }
    }
}
