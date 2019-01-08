using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using kcconstruction.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace kcconstruction.Pages.Stroitelstvo
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
                    Title = "Утепленная шведская плита(УШП) в Гатчинской районе",
                    Name = "ushpvgatchine_str",
                    PathToImagesSm = new List<string>
                    {
                        "/images/Stroitelstvo/Fundamenty/Gatchina_fundament/FG_004_sm.jpg",
                        "/images/Stroitelstvo/Fundamenty/Gatchina_fundament/FG_001_sm.jpg",
                        "/images/Stroitelstvo/Fundamenty/Gatchina_fundament/FG_002_sm.jpg",
                        "/images/Stroitelstvo/Fundamenty/Gatchina_fundament/FG_003_sm.jpg",
                        "/images/Stroitelstvo/Fundamenty/Gatchina_fundament/FG_005_sm.jpg",
                        "/images/Stroitelstvo/Fundamenty/Gatchina_fundament/FG_006_sm.jpg"
                    },
                    PathToImages = new List<string>
                    {
                        "/images/Stroitelstvo/Fundamenty/Gatchina_fundament/FG_004.jpg",
                        "/images/Stroitelstvo/Fundamenty/Gatchina_fundament/FG_001.jpg",
                        "/images/Stroitelstvo/Fundamenty/Gatchina_fundament/FG_002.jpg",
                        "/images/Stroitelstvo/Fundamenty/Gatchina_fundament/FG_003.jpg",
                        "/images/Stroitelstvo/Fundamenty/Gatchina_fundament/FG_005.jpg",
                        "/images/Stroitelstvo/Fundamenty/Gatchina_fundament/FG_006.jpg"
                    }

                },
                new GallerySnippetViewModel
                {
                    Title = "Мелкозаглубленный плитный железобентонный фундамент в Сосново",
                    Name="melkozagluvlennsosnovo_str",
                    PathToImagesSm = new List<string>
                    {
                        "/images/Stroitelstvo/Fundamenty/Pjatireche_fundament/FP_005_sm.jpg",
                        "/images/Stroitelstvo/Fundamenty/Pjatireche_fundament/FP_001_sm.jpg",
                        "/images/Stroitelstvo/Fundamenty/Pjatireche_fundament/FP_004_sm.jpg",
                        "/images/Stroitelstvo/Fundamenty/Pjatireche_fundament/FP_002_sm.jpg",
                        "/images/Stroitelstvo/Fundamenty/Pjatireche_fundament/FP_003_sm.jpg",
                        "/images/Stroitelstvo/Fundamenty/Pjatireche_fundament/FP_006_sm.jpg",
                        "/images/Stroitelstvo/Fundamenty/Pjatireche_fundament/FP_007_sm.jpg",
                        "/images/Stroitelstvo/Fundamenty/Pjatireche_fundament/FP_008_sm.jpg",
                        "/images/Stroitelstvo/Fundamenty/Pjatireche_fundament/FP_009_sm.jpg",
                        "/images/Stroitelstvo/Fundamenty/Pjatireche_fundament/FP_010_sm.jpg",
                        "/images/Stroitelstvo/Fundamenty/Pjatireche_fundament/FP_011_sm.jpg",
                        "/images/Stroitelstvo/Fundamenty/Pjatireche_fundament/FP_012_sm.jpg",
                        "/images/Stroitelstvo/Fundamenty/Pjatireche_fundament/FP_013_sm.jpg"
                    },
                    PathToImages = new List<string>
                    {
                        "/images/Stroitelstvo/Fundamenty/Pjatireche_fundament/FP_005.jpg",
                        "/images/Stroitelstvo/Fundamenty/Pjatireche_fundament/FP_001.jpg",
                        "/images/Stroitelstvo/Fundamenty/Pjatireche_fundament/FP_002.jpg",
                        "/images/Stroitelstvo/Fundamenty/Pjatireche_fundament/FP_003.jpg",
                        "/images/Stroitelstvo/Fundamenty/Pjatireche_fundament/FP_004.jpg",
                        "/images/Stroitelstvo/Fundamenty/Pjatireche_fundament/FP_006.jpg",
                        "/images/Stroitelstvo/Fundamenty/Pjatireche_fundament/FP_007.jpg",
                        "/images/Stroitelstvo/Fundamenty/Pjatireche_fundament/FP_008.jpg",
                        "/images/Stroitelstvo/Fundamenty/Pjatireche_fundament/FP_009.jpg",
                        "/images/Stroitelstvo/Fundamenty/Pjatireche_fundament/FP_010.jpg",
                        "/images/Stroitelstvo/Fundamenty/Pjatireche_fundament/FP_011.jpg",
                        "/images/Stroitelstvo/Fundamenty/Pjatireche_fundament/FP_012.jpg",
                        "/images/Stroitelstvo/Fundamenty/Pjatireche_fundament/FP_013.jpg"
                    }
                }

            });
        }
    }
}