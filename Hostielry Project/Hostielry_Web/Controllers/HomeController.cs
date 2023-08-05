using HostelryAPI.APIModels.APIData;
using HostelryWeb.WebModels.Dto;
using MagicVilla_Utility;
using MagicVilla_Web.Services.IServices;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace HostelryWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly IHostelryService _villaService;

        public HomeController(IHostelryService villaService)
        {
            _villaService = villaService;
        }

        public async Task<IActionResult> Index()
        {
            List<VillaDTO> list = new();

            var response = await _villaService.GetAllAsync<APIResponse>(HttpContext.Session.GetString(SD.SessionToken));
            if (response != null && response.IsSuccess)
                list = JsonConvert.DeserializeObject<List<VillaDTO>>(Convert.ToString(response.Result));
            
            return View(list);
        }
    }
}
