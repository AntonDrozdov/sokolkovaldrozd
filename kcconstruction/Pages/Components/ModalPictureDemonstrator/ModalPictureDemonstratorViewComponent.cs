using System.Threading.Tasks;
using kcconstruction.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace kcconstruction.Web.Pages.Components.ModalPictureDemonstrator
{
    public class ModalPictureDemonstratorViewComponent: ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(PictureDemonstratorViewModel model)
        {
            return View(model);
        }
    }
}
