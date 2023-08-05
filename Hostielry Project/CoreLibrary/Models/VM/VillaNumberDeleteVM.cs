using HostelryWeb.WebModels.Dto;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace HostelryWeb.WebModels.VM
{
    public class VillaNumberDeleteVM
    {
        public VillaNumberDeleteVM()
        {
            VillaNumber = new VillaNumberDTO();
        }

        public VillaNumberDTO VillaNumber { get; set; }
        
        [ValidateNever]
        public IEnumerable<SelectListItem> VillaList { get; set; }
    }
}
