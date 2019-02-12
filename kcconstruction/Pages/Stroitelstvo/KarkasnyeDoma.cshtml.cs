using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using kcconstruction.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace kcconstruction.Pages.Stroitelstvo
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
                    Title = "Каркасный дом в стиле \"Фрейм-Хаус\" в Разметелево",
                    Name="karkasfreinhausrazmetelevo",
                    PathToImagesSm = new List<string>
                    {
                        
                        "/images/Stroitelstvo/KarkasnyeDoma/Razmetelevo_karkas/IGDR_004_sm.jpg",
                        "/images/Stroitelstvo/KarkasnyeDoma/Razmetelevo_karkas/IGDR_001_sm.jpg",
                        "/images/Stroitelstvo/KarkasnyeDoma/Razmetelevo_karkas/IGDR_008_sm.jpg",
                        "/images/Stroitelstvo/KarkasnyeDoma/Razmetelevo_karkas/IGDR_003_sm.jpg",
                        "/images/Stroitelstvo/KarkasnyeDoma/Razmetelevo_karkas/IGDR_005_sm.jpg",
                        "/images/Stroitelstvo/KarkasnyeDoma/Razmetelevo_karkas/IGDR_006_sm.jpg",
                        "/images/Stroitelstvo/KarkasnyeDoma/Razmetelevo_karkas/IGDR_010_sm.jpg",
                        "/images/Stroitelstvo/KarkasnyeDoma/Razmetelevo_karkas/IGDR_002_sm.jpg",
                        "/images/Stroitelstvo/KarkasnyeDoma/Razmetelevo_karkas/IGDR_007_sm.jpg",
                        "/images/Stroitelstvo/KarkasnyeDoma/Razmetelevo_karkas/IGDR_009_sm.jpg"
                    },
                    PathToImages = new List<string>
                    {
                        "/images/Stroitelstvo/KarkasnyeDoma/Razmetelevo_karkas/IGDR_004.jpg",
                        "/images/Stroitelstvo/KarkasnyeDoma/Razmetelevo_karkas/IGDR_001.jpg",
                        "/images/Stroitelstvo/KarkasnyeDoma/Razmetelevo_karkas/IGDR_002.jpg",
                        "/images/Stroitelstvo/KarkasnyeDoma/Razmetelevo_karkas/IGDR_003.jpg",
                        "/images/Stroitelstvo/KarkasnyeDoma/Razmetelevo_karkas/IGDR_005.jpg",
                        "/images/Stroitelstvo/KarkasnyeDoma/Razmetelevo_karkas/IGDR_006.jpg",
                        "/images/Stroitelstvo/KarkasnyeDoma/Razmetelevo_karkas/IGDR_010.jpg",
                        "/images/Stroitelstvo/KarkasnyeDoma/Razmetelevo_karkas/IGDR_008.jpg",
                        "/images/Stroitelstvo/KarkasnyeDoma/Razmetelevo_karkas/IGDR_009.jpg",
                        "/images/Stroitelstvo/KarkasnyeDoma/Razmetelevo_karkas/IGDR_007.jpg"

                    },
                    FullCycleLink = "Proektirovanie/KarkasnyeDoma",
                    Region = "Ленинградская область",
                    CommonProperties = "Проект индивидуального жилого дома в стиле Timber Frame.\r\nДанный проект является уникальным по своей архитектуре и техноголии.\r\nБыли применены конструкции из гнутоклееных деревянных балок,\r\nизготовленных на самом современном производстве в России.\r\nНа навесе, прилегающем к дому, реальзованы деревянные фермы на подвижных опорах. В индивидуальном жилом строительстве подобное решение - большая редкость. ",
                    BuildingType = "Индивидуальный жилой дом",
                    Technology = "Деревянный каркас с утеплением стен 250мм и кровли 300мм. Тип кровли - мягкая черепица Shinglas. Наружная отделка стен - имитация брус. Отделка цоколя - натуральный камень.",
                    FundamentType = "Монолитная железобетонная плита с утеплением по периметру.",
                    Floor = "2х этажный",
                    Sizes = "18х11м ",
                    Square = "240м2",
                    IsFullCycled = true

                },
                new GallerySnippetViewModel
                {
                    Title = "Каркасная баня в Разметелево",
                    Name="karkasbanyavrazmetelevo",
                    PathToImagesSm = new List<string>
                    {
                        "/images/Stroitelstvo/KarkasnyeDoma/Razmetelevobany_karkas/IGDRb_002_sm.jpg",
                        "/images/Stroitelstvo/KarkasnyeDoma/Razmetelevobany_karkas/IGDRb_004_sm.jpg",
                        "/images/Stroitelstvo/KarkasnyeDoma/Razmetelevobany_karkas/IGDRb_001_sm.jpg",
                        "/images/Stroitelstvo/KarkasnyeDoma/Razmetelevobany_karkas/IGDRb_003_sm.jpg",
                        "/images/Stroitelstvo/KarkasnyeDoma/Razmetelevobany_karkas/IGDRb_005_sm.jpg"
                    },
                    PathToImages = new List<string>
                    {
                        "/images/Stroitelstvo/KarkasnyeDoma/Razmetelevobany_karkas/IGDRb_002.jpg",
                        "/images/Stroitelstvo/KarkasnyeDoma/Razmetelevobany_karkas/IGDRb_004.jpg",
                        "/images/Stroitelstvo/KarkasnyeDoma/Razmetelevobany_karkas/IGDRb_001.jpg",
                        "/images/Stroitelstvo/KarkasnyeDoma/Razmetelevobany_karkas/IGDRb_003.jpg",
                        "/images/Stroitelstvo/KarkasnyeDoma/Razmetelevobany_karkas/IGDRb_005.jpg"
                    },
                    FullCycleLink = "Proektirovanie/KarkasnyeDoma",
                    Region = "Ленинградская область",
                    CommonProperties = "",
                    BuildingType = "",
                    Technology = "",
                    FundamentType = "",
                    Floor = "",
                    Sizes = "",
                    Square = "",
                    IsFullCycled = false

                },
                new GallerySnippetViewModel
                {
                    Title = "Одноэтажный каркасный дом в Рощино",
                    Name="odnoetazhrochino",
                    PathToImagesSm = new List<string>
                    {
                        "/images/Stroitelstvo/KarkasnyeDoma/Roschino_karkas/IGDRo_001_sm.jpg",
                        "/images/Stroitelstvo/KarkasnyeDoma/Roschino_karkas/IGDRo_004_sm.jpg",
                        "/images/Stroitelstvo/KarkasnyeDoma/Roschino_karkas/IGDRo_002_sm.jpg",
                        "/images/Stroitelstvo/KarkasnyeDoma/Roschino_karkas/IGDRo_003_sm.jpg",
                        "/images/Stroitelstvo/KarkasnyeDoma/Roschino_karkas/IGDRo_005_sm.jpg",
                        "/images/Stroitelstvo/KarkasnyeDoma/Roschino_karkas/IGDRo_006_sm.jpg"
                    },
                    PathToImages = new List<string>
                    {
                        "/images/Stroitelstvo/KarkasnyeDoma/Roschino_karkas/IGDRo_001.jpg",
                        "/images/Stroitelstvo/KarkasnyeDoma/Roschino_karkas/IGDRo_004.jpg",
                        "/images/Stroitelstvo/KarkasnyeDoma/Roschino_karkas/IGDRo_002.jpg",
                        "/images/Stroitelstvo/KarkasnyeDoma/Roschino_karkas/IGDRo_003.jpg",
                        "/images/Stroitelstvo/KarkasnyeDoma/Roschino_karkas/IGDRo_005.jpg",
                        "/images/Stroitelstvo/KarkasnyeDoma/Roschino_karkas/IGDRo_006.jpg"
                    },
                    FullCycleLink = "Proektirovanie/KarkasnyeDoma",
                    Region = "Ленинградская область",
                    CommonProperties = "",
                    BuildingType = "",
                    Technology = "",
                    FundamentType = "",
                    Floor = "",
                    Sizes = "",
                    Square = "",
                    IsFullCycled = false

                },
                new GallerySnippetViewModel
                {
                    Title = "Современный каркасный дом в Сосново",
                    Name = "sovremenkarkasvsosnovo",
                    PathToImagesSm = new List<string>
                    {
                        "/images/Stroitelstvo/KarkasnyeDoma/Sosnovo_karkas/IGDS_010_sm.jpg",
                        "/images/Stroitelstvo/KarkasnyeDoma/Sosnovo_karkas/IGDS_001_sm.jpg",
                        "/images/Stroitelstvo/KarkasnyeDoma/Sosnovo_karkas/IGDS_002_sm.jpg",
                        "/images/Stroitelstvo/KarkasnyeDoma/Sosnovo_karkas/IGDS_003_sm.jpg",
                        "/images/Stroitelstvo/KarkasnyeDoma/Sosnovo_karkas/IGDS_004_sm.jpg",
                        "/images/Stroitelstvo/KarkasnyeDoma/Sosnovo_karkas/IGDS_005_sm.jpg",
                        "/images/Stroitelstvo/KarkasnyeDoma/Sosnovo_karkas/IGDS_006_sm.jpg",
                        "/images/Stroitelstvo/KarkasnyeDoma/Sosnovo_karkas/IGDS_007_sm.jpg",
                        "/images/Stroitelstvo/KarkasnyeDoma/Sosnovo_karkas/IGDS_008_sm.jpg",
                        "/images/Stroitelstvo/KarkasnyeDoma/Sosnovo_karkas/IGDS_009_sm.jpg",
                        "/images/Stroitelstvo/KarkasnyeDoma/Sosnovo_karkas/IGDS_011_sm.jpg",
                        "/images/Stroitelstvo/KarkasnyeDoma/Sosnovo_karkas/IGDS_012_sm.jpg",
                    },
                    PathToImages = new List<string>
                    {
                        "/images/Stroitelstvo/KarkasnyeDoma/Sosnovo_karkas/IGDS_010.jpg",
                        "/images/Stroitelstvo/KarkasnyeDoma/Sosnovo_karkas/IGDS_001.jpg",
                        "/images/Stroitelstvo/KarkasnyeDoma/Sosnovo_karkas/IGDS_002.jpg",
                        "/images/Stroitelstvo/KarkasnyeDoma/Sosnovo_karkas/IGDS_003.jpg",
                        "/images/Stroitelstvo/KarkasnyeDoma/Sosnovo_karkas/IGDS_004.jpg",
                        "/images/Stroitelstvo/KarkasnyeDoma/Sosnovo_karkas/IGDS_005.jpg",
                        "/images/Stroitelstvo/KarkasnyeDoma/Sosnovo_karkas/IGDS_006.jpg",
                        "/images/Stroitelstvo/KarkasnyeDoma/Sosnovo_karkas/IGDS_007.jpg",
                        "/images/Stroitelstvo/KarkasnyeDoma/Sosnovo_karkas/IGDS_008.jpg",
                        "/images/Stroitelstvo/KarkasnyeDoma/Sosnovo_karkas/IGDS_009.jpg",
                        "/images/Stroitelstvo/KarkasnyeDoma/Sosnovo_karkas/IGDS_011.jpg",
                        "/images/Stroitelstvo/KarkasnyeDoma/Sosnovo_karkas/IGDS_012.jpg"
                    },
                    Region = "Ленинградская область",
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
                    Title = "Одноэтажный современнный каркасный дом в Выборге",
                    Name = "odnoetazhvyborg",
                    PathToImagesSm = new List<string>
                    {
                        "/images/Stroitelstvo/KarkasnyeDoma/Vyborg_karkas/IGDV_002_sm.jpg",
                        "/images/Stroitelstvo/KarkasnyeDoma/Vyborg_karkas/IGDV_001_sm.jpg",
                        "/images/Stroitelstvo/KarkasnyeDoma/Vyborg_karkas/IGDV_004_sm.jpg",
                        "/images/Stroitelstvo/KarkasnyeDoma/Vyborg_karkas/IGDV_003_sm.jpg",
                        "/images/Stroitelstvo/KarkasnyeDoma/Vyborg_karkas/IGDV_005_sm.jpg",
                        "/images/Stroitelstvo/KarkasnyeDoma/Vyborg_karkas/IGDV_006_sm.jpg"
                    },
                    PathToImages = new List<string>
                    {
                        "/images/Stroitelstvo/KarkasnyeDoma/Vyborg_karkas/IGDV_002.jpg",
                        "/images/Stroitelstvo/KarkasnyeDoma/Vyborg_karkas/IGDV_001.jpg",
                        "/images/Stroitelstvo/KarkasnyeDoma/Vyborg_karkas/IGDV_003.jpg",
                        "/images/Stroitelstvo/KarkasnyeDoma/Vyborg_karkas/IGDV_004.jpg",
                        "/images/Stroitelstvo/KarkasnyeDoma/Vyborg_karkas/IGDV_005.jpg",
                        "/images/Stroitelstvo/KarkasnyeDoma/Vyborg_karkas/IGDV_006.jpg"
                    },
                    FullCycleLink = "Proektirovanie/KarkasnyeDoma",
                    Region = "Выборг",
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