using CoreLibrary.Enums;
using HostelryWeb.Services.Services;
using HostelryWeb.WebModels.APIModels;
using HostelryWeb.WebModels.RegistrationModels;
using MagicVilla_Web.Services.IServices;

namespace HostelryWeb.Services.Service
{
    public class AuthService : BaseService, IAuthService
    {
        private readonly IHttpClientFactory _clientFactory;
        private string controllerUrl;

        public AuthService(IHttpClientFactory clientFactory, IConfiguration configuration) : base(clientFactory)
        {
            _clientFactory = clientFactory;
            controllerUrl = configuration.GetValue<string>("ServiceUrls:HostelryAPI");

        }

        public Task<T> LoginAsync<T>(LoginRequestDTO obj)
        {
            return SendAsync<T>(new APIRequest()
            {
                ApiType = ApiTypeEnum.POST,
                Data = obj,
                Url = controllerUrl + "/api/v1/Users/login"
            });
        }

        public Task<T> RegisterAsync<T>(RegisterationRequestDTO obj)
        {
            return SendAsync<T>(new APIRequest()
            {
                ApiType = ApiTypeEnum.POST,
                Data = obj,
                Url = controllerUrl + "/api/v1/Users/register"
            });
        }
    }
}
