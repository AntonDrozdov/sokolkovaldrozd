using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace kcconstruction.Web.Pages.Components.MainMenu
{
    public class MainMenuViewComponent: ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
