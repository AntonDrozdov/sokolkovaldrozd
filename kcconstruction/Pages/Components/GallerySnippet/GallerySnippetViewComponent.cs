using System.Threading.Tasks;
using kcconstruction.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace kcconstruction.Web.Pages.Components.GallerySnippet
{ 
    public class GallerySnippetViewComponent: ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(GallerySnippetViewModel model)
        {
            return View(model);
        }
    }
}
