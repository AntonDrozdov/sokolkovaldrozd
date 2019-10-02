using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace kcconstruction.Web.Pages.Components.Footer
{
    public class FooterViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
