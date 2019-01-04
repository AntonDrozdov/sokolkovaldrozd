using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using kcconstruction.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace kcconstruction.Pages.Proektirovanie
{
    public class StropilnyeSistemyModel : PageModel
    {
        public List<GallerySnippetViewModel> Galleries = new List<GallerySnippetViewModel>();

        public void OnGet()
        {
            Galleries.AddRange(new List<GallerySnippetViewModel>
            {
                new GallerySnippetViewModel
                {
                    Name = "SK1",
                    PathToImagesSm = new List<string>
                    {
                        "/images/Proektirovanie/StropilnyeSistemy/SK1/SK1_001_sm.jpg",
                        "/images/Proektirovanie/StropilnyeSistemy/SK1/SK1_004_sm.jpg",
                        "/images/Proektirovanie/StropilnyeSistemy/SK1/SK1_002_sm.jpg",
                        "/images/Proektirovanie/StropilnyeSistemy/SK1/SK1_003_sm.jpg",
                        "/images/Proektirovanie/StropilnyeSistemy/SK1/SK1_005_sm.jpg"
                    },
                    PathToImages = new List<string>
                    {
                        "/images/Proektirovanie/StropilnyeSistemy/SK1/SK1_001.jpg",
                        "/images/Proektirovanie/StropilnyeSistemy/SK1/SK1_002.jpg",
                        "/images/Proektirovanie/StropilnyeSistemy/SK1/SK1_003.jpg",
                        "/images/Proektirovanie/StropilnyeSistemy/SK1/SK1_004.jpg",
                        "/images/Proektirovanie/StropilnyeSistemy/SK1/SK1_005.jpg"
                    }

                },
                new GallerySnippetViewModel
                {
                    Name = "SK2",
                    PathToImagesSm = new List<string>
                    {
                        "/images/Proektirovanie/StropilnyeSistemy/SK2/SK2_001_sm.jpg",
                        "/images/Proektirovanie/StropilnyeSistemy/SK2/SK2_004_sm.jpg",
                        "/images/Proektirovanie/StropilnyeSistemy/SK2/SK2_002_sm.jpg",
                        "/images/Proektirovanie/StropilnyeSistemy/SK2/SK2_003_sm.jpg",
                        "/images/Proektirovanie/StropilnyeSistemy/SK2/SK2_005_sm.jpg",
                        "/images/Proektirovanie/StropilnyeSistemy/SK2/SK2_006_sm.jpg"
                    },
                    PathToImages = new List<string>
                    {
                        "/images/Proektirovanie/StropilnyeSistemy/SK2/SK2_001.jpg",
                        "/images/Proektirovanie/StropilnyeSistemy/SK2/SK2_002.jpg",
                        "/images/Proektirovanie/StropilnyeSistemy/SK2/SK2_003.jpg",
                        "/images/Proektirovanie/StropilnyeSistemy/SK2/SK2_004.jpg",
                        "/images/Proektirovanie/StropilnyeSistemy/SK2/SK2_005.jpg",
                        "/images/Proektirovanie/StropilnyeSistemy/SK2/SK2_006.jpg"
                    }

                }
            });
        }
    }
}