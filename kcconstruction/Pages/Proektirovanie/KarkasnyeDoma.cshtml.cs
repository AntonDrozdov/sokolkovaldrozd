using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using kcconstruction.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace kcconstruction.Pages.Proektirovanie
{
    public class KarkasnyeDomaModel : PageModel
    {
        public List<GallerySnippetViewModel> Galleries = new List<GallerySnippetViewModel>();

        public void OnGet()
        {
            Galleries.AddRange(new List<GallerySnippetViewModel>
            {
                new GallerySnippetViewModel
                {
                    Title = "Одноэтажный дом в стиле \"Барн\"",
                    Name = "odnoetazbarn_prj",
                    PathToImagesSm = new List<string>
                    {
                        "/images/Proektirovanie/KarkasnyeDoma/KD1/KD1_001_sm.jpg",
                        "/images/Proektirovanie/KarkasnyeDoma/KD1/KD1_004_sm.jpg",
                        "/images/Proektirovanie/KarkasnyeDoma/KD1/KD1_002_sm.jpg",
                        "/images/Proektirovanie/KarkasnyeDoma/KD1/KD1_003_sm.jpg",
                        "/images/Proektirovanie/KarkasnyeDoma/KD1/KD1_005_sm.jpg",
                        "/images/Proektirovanie/KarkasnyeDoma/KD1/KD1_006_sm.jpg",
                        "/images/Proektirovanie/KarkasnyeDoma/KD1/KD1_007_sm.jpg",
                        "/images/Proektirovanie/KarkasnyeDoma/KD1/KD1_008_sm.jpg",
                        "/images/Proektirovanie/KarkasnyeDoma/KD1/KD1_009_sm.jpg",
                        "/images/Proektirovanie/KarkasnyeDoma/KD1/KD1_010_sm.jpg"
                    },
                    PathToImages = new List<string>
                    {
                        "/images/Proektirovanie/KarkasnyeDoma/KD1/KD1_001.jpg",
                        "/images/Proektirovanie/KarkasnyeDoma/KD1/KD1_002.jpg",
                        "/images/Proektirovanie/KarkasnyeDoma/KD1/KD1_003.jpg",
                        "/images/Proektirovanie/KarkasnyeDoma/KD1/KD1_004.jpg",
                        "/images/Proektirovanie/KarkasnyeDoma/KD1/KD1_005.jpg",
                        "/images/Proektirovanie/KarkasnyeDoma/KD1/KD1_006.jpg",
                        "/images/Proektirovanie/KarkasnyeDoma/KD1/KD1_007.jpg",
                        "/images/Proektirovanie/KarkasnyeDoma/KD1/KD1_008.jpg",
                        "/images/Proektirovanie/KarkasnyeDoma/KD1/KD1_009.jpg",
                        "/images/Proektirovanie/KarkasnyeDoma/KD1/KD1_010.jpg"
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
                    Title = "Каркасный дом в стиле \"Фрейм-Хаус\" в Разметелево",
                    Name = "karkasfreinhausrazmetelevo_prj",
                    PathToImagesSm = new List<string>
                    {
                        "/images/Proektirovanie/KarkasnyeDoma/KD2/KD2_001_sm.jpg",
                        "/images/Proektirovanie/KarkasnyeDoma/KD2/KD2_004_sm.jpg",
                        "/images/Proektirovanie/KarkasnyeDoma/KD2/KD2_002_sm.jpg",
                        "/images/Proektirovanie/KarkasnyeDoma/KD2/KD2_003_sm.jpg",
                        "/images/Proektirovanie/KarkasnyeDoma/KD2/KD2_005_sm.jpg",
                        "/images/Proektirovanie/KarkasnyeDoma/KD2/KD2_006_sm.jpg",
                        "/images/Proektirovanie/KarkasnyeDoma/KD2/KD2_007_sm.jpg"
                    },
                    PathToImages = new List<string>
                    {
                        "/images/Proektirovanie/KarkasnyeDoma/KD2/KD2_001.jpg",
                        "/images/Proektirovanie/KarkasnyeDoma/KD2/KD2_002.jpg",
                        "/images/Proektirovanie/KarkasnyeDoma/KD2/KD2_003.jpg",
                        "/images/Proektirovanie/KarkasnyeDoma/KD2/KD2_004.jpg",
                        "/images/Proektirovanie/KarkasnyeDoma/KD2/KD2_005.jpg",
                        "/images/Proektirovanie/KarkasnyeDoma/KD2/KD2_006.jpg",
                        "/images/Proektirovanie/KarkasnyeDoma/KD2/KD2_007.jpg"
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
                    Title = "Каркасный дом с имитацией под клееный брус",
                    Name= "karkassimitacieykleen_prj",
                    PathToImagesSm = new List<string>
                    {
                        "/images/Proektirovanie/KarkasnyeDoma/KD3/KD3_001_sm.jpg",
                        "/images/Proektirovanie/KarkasnyeDoma/KD3/KD3_004_sm.jpg",
                        "/images/Proektirovanie/KarkasnyeDoma/KD3/KD3_002_sm.jpg",
                        "/images/Proektirovanie/KarkasnyeDoma/KD3/KD3_003_sm.jpg",
                        "/images/Proektirovanie/KarkasnyeDoma/KD3/KD3_005_sm.jpg",
                        "/images/Proektirovanie/KarkasnyeDoma/KD3/KD3_006_sm.jpg",
                        "/images/Proektirovanie/KarkasnyeDoma/KD3/KD3_007_sm.jpg"
                    },
                    PathToImages = new List<string>
                    {
                        "/images/Proektirovanie/KarkasnyeDoma/KD3/KD3_001.jpg",
                        "/images/Proektirovanie/KarkasnyeDoma/KD3/KD3_002.jpg",
                        "/images/Proektirovanie/KarkasnyeDoma/KD3/KD3_003.jpg",
                        "/images/Proektirovanie/KarkasnyeDoma/KD3/KD3_004.jpg",
                        "/images/Proektirovanie/KarkasnyeDoma/KD3/KD3_005.jpg",
                        "/images/Proektirovanie/KarkasnyeDoma/KD3/KD3_006.jpg",
                        "/images/Proektirovanie/KarkasnyeDoma/KD3/KD3_007.jpg"
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