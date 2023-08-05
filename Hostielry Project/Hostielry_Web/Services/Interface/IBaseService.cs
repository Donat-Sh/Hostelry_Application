using HostelryAPI.APIModels.APIData;
using HostelryWeb.WebModels.APIModels;

namespace MagicVilla_Web.Services.IServices
{
    public interface IBaseService
    {
        APIResponse responseModel { get; set; }
        Task<T> SendAsync<T>(APIRequest apiRequest);
    }
}
