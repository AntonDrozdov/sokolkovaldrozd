﻿using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace kcconstruction.Pages.Components.ModalPictureDemostrator
{
    public class ModalPictureDemonstratorViewComponent: ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
