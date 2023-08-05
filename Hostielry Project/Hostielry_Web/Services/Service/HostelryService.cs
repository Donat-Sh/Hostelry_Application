using CoreLibrary.Enums;
using HostelryWeb.Services.Services;
using HostelryWeb.WebModels.APIModels;
using HostelryWeb.WebModels.Dto;
using MagicVilla_Web.Services.IServices;

namespace HostelryWeb.Services.Service
{
    public class HostelryService : BaseService, IHostelryService
    {
        private readonly IHttpClientFactory _clientFactory;
        private string villaUrl;

        public HostelryService(IHttpClientFactory clientFactory, IConfiguration configuration) : base(clientFactory)
        {
            _clientFactory = clientFactory;
            villaUrl = configuration.GetValue<string>("ServiceUrls:HostelryAPI");
        }

        public Task<T> CreateAsync<T>(VillaCreateDTO dto, string token) => SendAsync<T>(new APIRequest()
        {
            ApiType = ApiTypeEnum.POST,
            Data = dto,
            Url = $"{villaUrl}/api/v1/Hostelry",
            Token = token
        });

        public Task<T> DeleteAsync<T>(int id, string token) => SendAsync<T>(new APIRequest()
        {
            ApiType = ApiTypeEnum.DELETE,
            Url = $"{villaUrl}/api/v1/Hostelry/{id}",
            Token = token
        });


        public Task<T> GetAllAsync<T>(string token) => SendAsync<T>(new APIRequest()
        {
            ApiType = ApiTypeEnum.GET,
            Url = $"{villaUrl}/api/v1/Hostelry",
            Token = token
        });

        public Task<T> GetAsync<T>(int id, string token) => SendAsync<T>(new APIRequest()
        {
            ApiType = ApiTypeEnum.GET,
            Url = $"{villaUrl}/api/v1/Hostelry/{id}",
            Token = token
        });

        public Task<T> UpdateAsync<T>(VillaUpdateDTO dto, string token) => SendAsync<T>(new APIRequest()
        {
            ApiType = ApiTypeEnum.PUT,
            Data = dto,
            Url = $"{villaUrl}/api/v1/Hostelry/{dto.Id}",
            Token = token
        });
    }
}
