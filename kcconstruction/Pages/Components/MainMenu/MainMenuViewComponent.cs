using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace kcconstruction.Pages.Components.MainMenu
{
    public class MainMenuViewComponent: ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
