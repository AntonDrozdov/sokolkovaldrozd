using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using kcconstruction.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace kcconstruction.Pages.Stroitelstvo
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
                    Title = "Крыша гаража со стропильными фермами в Кировске",
                    Name ="kryshasostropkirovsk",
                    PathToImagesSm = new List<string>
                    {
                        "/images/Stroitelstvo/StropilnyeSistemy/Kirovsk_strop/GK_004_sm.jpg",
                        "/images/Stroitelstvo/StropilnyeSistemy/Kirovsk_strop/GK_001_sm.jpg",
                        "/images/Stroitelstvo/StropilnyeSistemy/Kirovsk_strop/GK_002_sm.jpg",
                        "/images/Stroitelstvo/StropilnyeSistemy/Kirovsk_strop/GK_003_sm.jpg",
                        "/images/Stroitelstvo/StropilnyeSistemy/Kirovsk_strop/GK_005_sm.jpg"
                    },
                    PathToImages = new List<string>
                    {
                        "/images/Stroitelstvo/StropilnyeSistemy/Kirovsk_strop/GK_004.jpg",
                        "/images/Stroitelstvo/StropilnyeSistemy/Kirovsk_strop/GK_001.jpg",
                        "/images/Stroitelstvo/StropilnyeSistemy/Kirovsk_strop/GK_002.jpg",
                        "/images/Stroitelstvo/StropilnyeSistemy/Kirovsk_strop/GK_003.jpg",
                        "/images/Stroitelstvo/StropilnyeSistemy/Kirovsk_strop/GK_005.jpg"
                    },
                    FullCycleLink= "Proektirovanie/StropilnyeSistemy",
                    Region = "Кировск",
                    CommonProperties = "",
                    BuildingType = "",
                    Technology = "",
                    FundamentType = "",
                    Floor = "",
                    Sizes = "",
                    Square = "",
                    IsFullCycled = true

                }
            });
        }
    }
}