using CoreLibrary.Enums;
using static MagicVilla_Utility.SD;

namespace HostelryWeb.WebModels.APIModels
{
    public class APIRequest
    {
        public ApiTypeEnum ApiType { get; set; } = ApiTypeEnum.GET;
        public string Url { get; set; }
        public object Data { get; set; }
        public string Token { get; set; }
    }
}
