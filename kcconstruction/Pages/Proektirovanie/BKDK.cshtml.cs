using System.Collections.Generic;
using kcconstruction.ViewModels;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace kcconstruction.Pages.Proektirovanie
{
    public class BKDKModel : PageModel
    {
        public List<GallerySnippetViewModel> Galleries = new List<GallerySnippetViewModel>();

        public void OnGet() 
        {
            Galleries.AddRange(new List<GallerySnippetViewModel>
            {
                new GallerySnippetViewModel
                {
                    Title = "Теннисный клуб в Подмосковье с пролетом ферм 55 м",
                    Name = "tennisclub_prj",
                    PathToImagesSm = new List<string>
                    {
                        "/images/Proektirovanie/BKDK/BKDK1/BKDK1_001_sm.jpg",
                        "/images/Proektirovanie/BKDK/BKDK1/BKDK1_004_sm.jpg",
                        "/images/Proektirovanie/BKDK/BKDK1/BKDK1_002_sm.jpg",
                        "/images/Proektirovanie/BKDK/BKDK1/BKDK1_003_sm.jpg",
                        "/images/Proektirovanie/BKDK/BKDK1/BKDK1_005_sm.jpg",
                        "/images/Proektirovanie/BKDK/BKDK1/BKDK1_006_sm.jpg",
                        "/images/Proektirovanie/BKDK/BKDK1/BKDK1_007_sm.jpg",
                        "/images/Proektirovanie/BKDK/BKDK1/BKDK1_008_sm.jpg"
                    },
                    PathToImages = new List<string>
                    {
                        "/images/Proektirovanie/BKDK/BKDK1/BKDK1_001.jpg",
                        "/images/Proektirovanie/BKDK/BKDK1/BKDK1_002.jpg",
                        "/images/Proektirovanie/BKDK/BKDK1/BKDK1_003.jpg",
                        "/images/Proektirovanie/BKDK/BKDK1/BKDK1_004.jpg",
                        "/images/Proektirovanie/BKDK/BKDK1/BKDK1_005.jpg",
                        "/images/Proektirovanie/BKDK/BKDK1/BKDK1_006.jpg",
                        "/images/Proektirovanie/BKDK/BKDK1/BKDK1_007.jpg",
                        "/images/Proektirovanie/BKDK/BKDK1/BKDK1_008.jpg"
                    },
                    Region = "",
                    CommonProperties = "",
                    BuildingType = "",
                    Technology = "",
                    FundamentType = "",
                    Floor = "",
                    Sizes = "",
                    Square = "",

                }, 
                new GallerySnippetViewModel
                {
                    Title = "Навес для хранения пиломатериалов с гнутоклееными рамами",
                    Name = "navesgnutokleen_prj",
                    PathToImagesSm = new List<string>
                    {
                        "/images/Proektirovanie/BKDK/BKDK2/BKDK2_001_sm.jpg",
                        "/images/Proektirovanie/BKDK/BKDK2/BKDK2_004_sm.jpg",
                        "/images/Proektirovanie/BKDK/BKDK2/BKDK2_002_sm.jpg",
                        "/images/Proektirovanie/BKDK/BKDK2/BKDK2_003_sm.jpg",
                        "/images/Proektirovanie/BKDK/BKDK2/BKDK2_005_sm.jpg",
                        "/images/Proektirovanie/BKDK/BKDK2/BKDK2_006_sm.jpg"
                    },
                    PathToImages = new List<string>
                    {
                        "/images/Proektirovanie/BKDK/BKDK2/BKDK2_001.jpg",
                        "/images/Proektirovanie/BKDK/BKDK2/BKDK2_002.jpg",
                        "/images/Proektirovanie/BKDK/BKDK2/BKDK2_003.jpg",
                        "/images/Proektirovanie/BKDK/BKDK2/BKDK2_004.jpg",
                        "/images/Proektirovanie/BKDK/BKDK2/BKDK2_005.jpg",
                        "/images/Proektirovanie/BKDK/BKDK2/BKDK2_006.jpg"
                    },
                    Region = "",
                    CommonProperties = "",
                    BuildingType = "",
                    Technology = "",
                    FundamentType = "",
                    Floor = "",
                    Sizes = "",
                    Square = "",
                },
                new GallerySnippetViewModel
                {
                    Title= "Производственный цех в Ленинградской области с металлодеревянными фермами",
                    Name = "proizvodstcex_prj",
                    PathToImagesSm = new List<string>
                    {
                        "/images/Proektirovanie/BKDK/BKDK3/BKDK3_001_sm.jpg",
                        "/images/Proektirovanie/BKDK/BKDK3/BKDK3_004_sm.jpg",
                        "/images/Proektirovanie/BKDK/BKDK3/BKDK3_002_sm.jpg",
                        "/images/Proektirovanie/BKDK/BKDK3/BKDK3_003_sm.jpg",
                        "/images/Proektirovanie/BKDK/BKDK3/BKDK3_005_sm.jpg"
                    },
                    PathToImages = new List<string>
                    {
                        "/images/Proektirovanie/BKDK/BKDK3/BKDK3_001.jpg",
                        "/images/Proektirovanie/BKDK/BKDK3/BKDK3_002.jpg",
                        "/images/Proektirovanie/BKDK/BKDK3/BKDK3_003.jpg",
                        "/images/Proektirovanie/BKDK/BKDK3/BKDK3_004.jpg",
                        "/images/Proektirovanie/BKDK/BKDK3/BKDK3_005.jpg"
                    },
                    Region = "",
                    CommonProperties = "",
                    BuildingType = "",
                    Technology = "",
                    FundamentType = "",
                    Floor = "",
                    Sizes = "",
                    Square = "",
                },
                new GallerySnippetViewModel
                {
                    Title = "\"Ферма-ножницы\" на здании ресторана в Карелии",
                    Name="fermanpznicy_prj",
                    PathToImagesSm = new List<string>
                    {
                        "/images/Proektirovanie/BKDK/BKDK4/BKDK4_001_sm.jpg",
                        "/images/Proektirovanie/BKDK/BKDK4/BKDK4_004_sm.jpg",
                        "/images/Proektirovanie/BKDK/BKDK4/BKDK4_002_sm.jpg",
                        "/images/Proektirovanie/BKDK/BKDK4/BKDK4_003_sm.jpg",
                        "/images/Proektirovanie/BKDK/BKDK4/BKDK4_005_sm.jpg",
                        "/images/Proektirovanie/BKDK/BKDK4/BKDK4_006_sm.jpg",
                        "/images/Proektirovanie/BKDK/BKDK4/BKDK4_007_sm.jpg",
                        "/images/Proektirovanie/BKDK/BKDK4/BKDK4_008_sm.jpg"
                    },
                    PathToImages = new List<string>
                    {
                        "/images/Proektirovanie/BKDK/BKDK4/BKDK4_001.jpg",
                        "/images/Proektirovanie/BKDK/BKDK4/BKDK4_002.jpg",
                        "/images/Proektirovanie/BKDK/BKDK4/BKDK4_003.jpg",
                        "/images/Proektirovanie/BKDK/BKDK4/BKDK4_004.jpg",
                        "/images/Proektirovanie/BKDK/BKDK4/BKDK4_005.jpg",
                        "/images/Proektirovanie/BKDK/BKDK4/BKDK4_006.jpg",
                        "/images/Proektirovanie/BKDK/BKDK4/BKDK4_007.jpg",
                        "/images/Proektirovanie/BKDK/BKDK4/BKDK4_008.jpg"
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