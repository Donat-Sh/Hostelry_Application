using CoreLibrary.Enums;
using HostelryWeb.Services.Services;
using HostelryWeb.WebModels.APIModels;
using HostelryWeb.WebModels.Dto;
using MagicVilla_Web.Services.IServices;

namespace HostelryWeb.Services.Service
{
    public class HostelryNumService : BaseService, IHostelryNumService
    {
        private readonly IHttpClientFactory _clientFactory;
        private string villaUrl;

        public HostelryNumService(IHttpClientFactory clientFactory, IConfiguration configuration) : base(clientFactory)
        {
            _clientFactory = clientFactory;
            villaUrl = configuration.GetValue<string>("ServiceUrls:HostelryAPI");
        }

        public Task<T> CreateAsync<T>(VillaNumberCreateDTO dto, string token) => SendAsync<T>(new APIRequest()
        {
            ApiType = ApiTypeEnum.POST,
            Data = dto,
            Url = $"{villaUrl}/api/v1/HostelryNum",
            Token = token
        });

        public Task<T> DeleteAsync<T>(int id, string token) => SendAsync<T>(new APIRequest()
        {
            ApiType = ApiTypeEnum.DELETE,
            Url = $"{villaUrl}/api/v1/HostelryNum/{id}",
            Token = token
        });

        public Task<T> GetAllAsync<T>(string token) => SendAsync<T>(new APIRequest()
        {
            ApiType = ApiTypeEnum.GET,
            Url = $"{villaUrl}/api/v1/HostelryNum",
            Token = token
        });

        public Task<T> GetAsync<T>(int id, string token) => SendAsync<T>(new APIRequest()
        {
            ApiType = ApiTypeEnum.GET,
            Url = $"{villaUrl}/api/v1/HostelryNum/{id}",
            Token = token
        });

        public Task<T> UpdateAsync<T>(VillaNumberUpdateDTO dto, string token) => SendAsync<T>(new APIRequest()
        {
            ApiType = ApiTypeEnum.PUT,
            Data = dto,
            Url = $"{villaUrl}/api/v1/HostelryNum/{dto.VillaNo}",
            Token = token
        });
    }
}
