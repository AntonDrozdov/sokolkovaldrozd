using System.Threading.Tasks;
using kcconstruction.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace kcconstruction.Pages.Components.GallerySnippet
{ 
    public class GallerySnippetViewComponent: ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(GallerySnippetViewModel model)
        {
            return View(model);
        }
    }
}
