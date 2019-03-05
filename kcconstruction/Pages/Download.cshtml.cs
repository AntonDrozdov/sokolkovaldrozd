﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace kcconstruction.Pages
{
    public class DownloadModel : PageModel
    {
        public void OnGet()
        {

        }

        public ActionResult OnGetFile(string file)
        {
            return File("/forDownloading/" + file, "application/octet-stream", file);
        }

    }
}