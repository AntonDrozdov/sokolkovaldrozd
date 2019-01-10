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
                    Name ="kryshasostropkirovsk_str",
                    PathToImagesSm = new List<string>
                    {
                        "/images/Stroitelstvo/StropilnyeSistemy/Kirovsk_strop/GK_004_sm.jpg",
                        "/images/Stroitelstvo/StropilnyeSistemy/Kirovsk_strop/GK_001_sm.jpg",
                        "/images/Stroitelstvo/StropilnyeSistemy/Kirovsk_strop/GK_002_sm.jpg",
                        "/images/Stroitelstvo/StropilnyeSistemy/Kirovsk_strop/GK_003_sm.jpg",
                        "/images/Stroitelstvo/StropilnyeSistemy/Kirovsk_strop/GK_005_sm.jpg",
                        "/images/Stroitelstvo/StropilnyeSistemy/Kirovsk_strop/GK_006_sm.jpg",
                        "/images/Stroitelstvo/StropilnyeSistemy/Kirovsk_strop/GK_007_sm.jpg",
                        "/images/Stroitelstvo/StropilnyeSistemy/Kirovsk_strop/GK_008_sm.jpg",
                        "/images/Stroitelstvo/StropilnyeSistemy/Kirovsk_strop/GK_009_sm.jpg",
                        "/images/Stroitelstvo/StropilnyeSistemy/Kirovsk_strop/GK_010_sm.jpg",
                        "/images/Stroitelstvo/StropilnyeSistemy/Kirovsk_strop/GK_011_sm.jpg"
                    },
                    PathToImages = new List<string>
                    {
                        "/images/Stroitelstvo/StropilnyeSistemy/Kirovsk_strop/GK_004.jpg",
                        "/images/Stroitelstvo/StropilnyeSistemy/Kirovsk_strop/GK_001.jpg",
                        "/images/Stroitelstvo/StropilnyeSistemy/Kirovsk_strop/GK_002.jpg",
                        "/images/Stroitelstvo/StropilnyeSistemy/Kirovsk_strop/GK_003.jpg",
                        "/images/Stroitelstvo/StropilnyeSistemy/Kirovsk_strop/GK_005.jpg",
                        "/images/Stroitelstvo/StropilnyeSistemy/Kirovsk_strop/GK_006.jpg",
                        "/images/Stroitelstvo/StropilnyeSistemy/Kirovsk_strop/GK_007.jpg",
                        "/images/Stroitelstvo/StropilnyeSistemy/Kirovsk_strop/GK_008.jpg",
                        "/images/Stroitelstvo/StropilnyeSistemy/Kirovsk_strop/GK_009.jpg",
                        "/images/Stroitelstvo/StropilnyeSistemy/Kirovsk_strop/GK_010.jpg",
                        "/images/Stroitelstvo/StropilnyeSistemy/Kirovsk_strop/GK_011.jpg"
                    },
                    Region = "",
                    CommonProperties = "",
                    BuildingType = "",
                    Technology = "",
                    FundamentType = "",
                    Floor = "",
                    Sizes = "",
                    Square = "",

                }
            });
        }
    }
}