using System.Threading.Tasks;
using kcconstruction.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace kcconstruction.Pages.Components.PredlozhenieSnippet
{ 
    public class PredlozhenieSnippetViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(PredlozhenieSnippetViewModel model)
        {
            return View(model);
        }
    }
}
