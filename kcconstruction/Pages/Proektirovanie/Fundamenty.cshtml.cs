using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using kcconstruction.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace kcconstruction.Pages.Proektirovanie
{
    public class FundamentyModel : PageModel
    {
        public List<GallerySnippetViewModel> Galleries = new List<GallerySnippetViewModel>();

        public void OnGet()

        {
            Galleries.AddRange(new List<GallerySnippetViewModel>
            {
                new GallerySnippetViewModel
                {
                    Title = "Мелкозаглубленный ленточный фундамент с цокольным этажом",
                    Name ="melozaglublennyscokolem_prj",
                    PathToImagesSm = new List<string>
                    {
                        "/images/Proektirovanie/Fundamenty/PF1/PF1_001_sm.jpg",
                        "/images/Proektirovanie/Fundamenty/PF1/PF1_004_sm.jpg",
                        "/images/Proektirovanie/Fundamenty/PF1/PF1_002_sm.jpg",
                        "/images/Proektirovanie/Fundamenty/PF1/PF1_003_sm.jpg"
                    },
                    PathToImages = new List<string>
                    {
                        "/images/Proektirovanie/Fundamenty/PF1/PF1_001.jpg",
                        "/images/Proektirovanie/Fundamenty/PF1/PF1_004.jpg",
                        "/images/Proektirovanie/Fundamenty/PF1/PF1_002.jpg",
                        "/images/Proektirovanie/Fundamenty/PF1/PF1_003.jpg"
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
                    Title = "Мелкозаглубленный ленточный фундамент в Ленинградской области",
                    Name ="melkozaglublennylentochnyvlenobl_prj", 
                    PathToImagesSm = new List<string>
                    {
                        "/images/Proektirovanie/Fundamenty/PF2/PF2_001_sm.jpg",
                        "/images/Proektirovanie/Fundamenty/PF2/PF2_004_sm.jpg",
                        "/images/Proektirovanie/Fundamenty/PF2/PF2_002_sm.jpg",
                        "/images/Proektirovanie/Fundamenty/PF2/PF2_003_sm.jpg",
    
                    },
                    PathToImages = new List<string>
                    {
                        "/images/Proektirovanie/Fundamenty/PF2/PF2_001.jpg",
                        "/images/Proektirovanie/Fundamenty/PF2/PF2_002.jpg",
                        "/images/Proektirovanie/Fundamenty/PF2/PF2_003.jpg",
                        "/images/Proektirovanie/Fundamenty/PF2/PF2_004.jpg",
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
            });
        }
    }
}
