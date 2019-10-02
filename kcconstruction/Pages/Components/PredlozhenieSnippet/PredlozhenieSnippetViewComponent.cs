using System.Threading.Tasks;
using kcconstruction.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace kcconstruction.Web.Pages.Components.PredlozhenieSnippet
{ 
    public class PredlozhenieSnippetViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(PredlozhenieSnippetViewModel model)
        {
            return View(model);
        }
    }
}
