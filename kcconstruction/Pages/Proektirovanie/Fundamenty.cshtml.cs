using System.Collections.Generic;
using kcconstruction.Web.ViewModels;
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
                    Region = "Ленинградская область",
                    CommonProperties = "Проект монолитного железобетонного фундамента. " +
                                       "Данный фундамент спроектирован под здание пожарного узла с прилегающим к нему резервуаром для воды. " +
                                       "Для реализации подобных проектов требуется применение специальных решений - таких как специальный водостойкий бетон и комплексная гидроизоляция.",
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
                    Region = "Ленинградская область",
                    CommonProperties = "Проект монолитного железобетонного фундамента. " +
                                       "Данный фундамент спроектирован под индивидуальный жилой дом. " +
                                       "Фундамент - монолитная железобетонная плита с ребрами вниз. " +
                                       "Проект реализован в поселке Репино Ленинградской области.",
                    BuildingType = "",
                    Technology = "",
                    FundamentType = "",
                    Floor = "",
                    Sizes = "",
                    Square = "",
                },
                new GallerySnippetViewModel
                {
                    Title = "Мелкозаглубленный плитный железобентонный фундамент в Сосново",
                    Name ="melkozaglublennyplotnysosnovo",
                    PathToImagesSm = new List<string>
                    {
                        "/images/Proektirovanie/Fundamenty/PF3/PF3_001_sm.jpg",
                        "/images/Proektirovanie/Fundamenty/PF3/PF3_004_sm.jpg",
                        "/images/Proektirovanie/Fundamenty/PF3/PF3_002_sm.jpg",
                        "/images/Proektirovanie/Fundamenty/PF3/PF3_003_sm.jpg",
                        "/images/Proektirovanie/Fundamenty/PF3/PF3_005_sm.jpg",

                    },
                    PathToImages = new List<string>
                    {
                        "/images/Proektirovanie/Fundamenty/PF3/PF3_001.jpg",
                        "/images/Proektirovanie/Fundamenty/PF3/PF3_002.jpg",
                        "/images/Proektirovanie/Fundamenty/PF3/PF3_003.jpg",
                        "/images/Proektirovanie/Fundamenty/PF3/PF3_004.jpg",
                        "/images/Proektirovanie/Fundamenty/PF3/PF3_005.jpg",
                    },
                    FullCycleLink = "Stroitelstvo/Fundamenty",
                    Region = "Ленинградская область",
                    CommonProperties = "Проект монолитного железобетонного фундамента и укрепления склона участка. " +
                                       "Данный фундамент спроектирован под индивидуальный жилой дом из клееного бруса площадью 300м.кв. " +
                                       "Конструктивная схема основания - монолитная железобетонная плита толщиной 200мм с ребрами 200х500мм вниз. " +
                                       "В данном проекте была выполнена работа по расчету несущей способности фундамента а также был запланирован ряд мероприятий по усилению грунтов учатка.",
                    BuildingType = "",
                    Technology = "",
                    FundamentType = "",
                    Floor = "",
                    Sizes = "",
                    Square = "",
                    IsFullCycled = true,
                },
            });
        }
    }
}
