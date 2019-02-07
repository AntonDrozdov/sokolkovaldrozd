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
                    FullCycleLink="Stroitelstvo/KarkasnyeDoma",
                    Region = "Ленинградская область",
                    CommonProperties = "Проект индивидуального жилого дома в стиле Barn House. " +
                                       "Он разработан с применением передовых решений: " +
                                       "несущий каркас из клееного бруса, " +
                                       "крепление конструкций на вклееные стержни, " +
                                       "реализация кровли без свесов.",
                    BuildingType = "",
                    Technology = "",
                    FundamentType = "",
                    Floor = "",
                    Sizes = "",
                    Square = ""
                },
                new GallerySnippetViewModel
                {
                    Title = "Каркасный дом в стиле \"Фрейм-Хаус\" в Разметелево",
                    Name = "karkasfreinhausrazmetelevo",
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
                    FullCycleLink= "Stroitelstvo/KarkasnyeDoma",
                    Region = "Ленинградская область",
                    CommonProperties = "Проект индивидуального жилого дома в стиле Timber Frame. " +
                                       "Данный проект является уникальным по своей архитектуре и техноголии. " +
                                       "Были применениы конструкции из гнутоклееных деревянных балок, изготовленных на самом современном производстве в России." +
                                       "На навесе, прилегающем к дому, реальзованы деревянные фермы на подвижных опорах. " +
                                       "В индивидуальном жилом строительстве подобное решение - большая редкость. ",
                    BuildingType = "Индивидуальный жилой дом",
                    Technology = "Деревянный каркас с утеплением стен 250мм и кровли 300мм. Тип кровли - мягкая черепица Shinglas. Наружная отделка стен - имитация брус. Отделка цоколя - натуральный камень. ",
                    FundamentType = "Монолитная железобетонная плита с утеплением по периметру",
                    Floor = "2",
                    Sizes = "18х11м ",
                    Square = "240м2",
                    IsFullCycled = true
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
                    Region = "Ленинградская область",
                    CommonProperties = "Проект индивидуального жилого дома. " +
                                       "Дом выполнен по современной каркасной технологии. " +
                                       "Отличительной особенностью данного проекта является его внешний вид - он выглядит как здание из клееного бруса, в том числе реализована имитация перерубов." +
                                       "Подобное сочетание позволяет совместить внешний вид брусового дома и в то же время избежать усадки и обеспечить энергоэффективность современного каркасного дома.",
                    BuildingType = "",
                    Technology = "",
                    FundamentType = "",
                    Floor = "",
                    Sizes = "",
                    Square = "",
                },
                new GallerySnippetViewModel
                {
                    Title = "Скандинавский каркасный дом в Рощино",
                    Name= "scandikarkarochino",
                    PathToImagesSm = new List<string>
                    {
                        "/images/Proektirovanie/KarkasnyeDoma/KD4/KD4_001_sm.jpg",
                        "/images/Proektirovanie/KarkasnyeDoma/KD4/KD4_004_sm.jpg",
                        "/images/Proektirovanie/KarkasnyeDoma/KD4/KD4_002_sm.jpg",
                        "/images/Proektirovanie/KarkasnyeDoma/KD4/KD4_003_sm.jpg",
                        "/images/Proektirovanie/KarkasnyeDoma/KD4/KD4_005_sm.jpg",
                        "/images/Proektirovanie/KarkasnyeDoma/KD4/KD4_006_sm.jpg",
                        "/images/Proektirovanie/KarkasnyeDoma/KD4/KD4_007_sm.jpg"
                    },
                    PathToImages = new List<string>
                    {
                        "/images/Proektirovanie/KarkasnyeDoma/KD4/KD4_001.jpg",
                        "/images/Proektirovanie/KarkasnyeDoma/KD4/KD4_002.jpg",
                        "/images/Proektirovanie/KarkasnyeDoma/KD4/KD4_003.jpg",
                        "/images/Proektirovanie/KarkasnyeDoma/KD4/KD4_004.jpg",
                        "/images/Proektirovanie/KarkasnyeDoma/KD4/KD4_005.jpg",
                        "/images/Proektirovanie/KarkasnyeDoma/KD4/KD4_006.jpg",
                        "/images/Proektirovanie/KarkasnyeDoma/KD4/KD4_007.jpg"
                    },
                    Region = "Ленинградская область",
                    CommonProperties = "Проект индивидуального жилого дома. " +
                                       "Дом выполнен по современной каркасной технологии. " +
                                       "Изначальный вариант этого проекта был в брусовой технологии. " +
                                       "Нами было произведено полное перепроектирование под каркас с изменением некоторых планировочных решений. " +
                                       "Данный объет - первый, реализованный нами. Строительство осуществлялось в 2006г.",

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
                    Name= "odnoetazhkarkasvyborg",
                    PathToImagesSm = new List<string>
                    {
                        "/images/Proektirovanie/KarkasnyeDoma/KD5/KD4_001_sm.jpg",
                        "/images/Proektirovanie/KarkasnyeDoma/KD5/KD4_004_sm.jpg",
                        "/images/Proektirovanie/KarkasnyeDoma/KD5/KD4_002_sm.jpg",
                        "/images/Proektirovanie/KarkasnyeDoma/KD5/KD4_003_sm.jpg",
                        "/images/Proektirovanie/KarkasnyeDoma/KD5/KD4_005_sm.jpg",
                        "/images/Proektirovanie/KarkasnyeDoma/KD5/KD4_006_sm.jpg",
                        "/images/Proektirovanie/KarkasnyeDoma/KD5/KD4_007_sm.jpg"
                    },
                    PathToImages = new List<string>
                    {
                        "/images/Proektirovanie/KarkasnyeDoma/KD5/KD4_001.jpg",
                        "/images/Proektirovanie/KarkasnyeDoma/KD5/KD4_002.jpg",
                        "/images/Proektirovanie/KarkasnyeDoma/KD5/KD4_003.jpg",
                        "/images/Proektirovanie/KarkasnyeDoma/KD5/KD4_004.jpg",
                        "/images/Proektirovanie/KarkasnyeDoma/KD5/KD4_005.jpg",
                        "/images/Proektirovanie/KarkasnyeDoma/KD5/KD4_006.jpg",
                        "/images/Proektirovanie/KarkasnyeDoma/KD5/KD4_007.jpg"
                    },
                    Region = "Выборг",
                    CommonProperties = "Проект индивидуального жилого дома. " +
                                       "Одноэтажный каркасный дом для круглогодичного проживания. " +
                                       "В связи с наличием на пятне застройки перепада высоты в 1300мм, Заказчиком был выбран вариант фундамента из буронабивных свай. " +
                                       "Цокольное перекрытие, одно из самых уязвимых мест в подобных проектах, было рассчитано с учетом всех возможных нагрузок и физиологических прогибов. " +
                                       "В итоге результат будет практически таким же \"монолитным\" как пол по плите. " +
                                       "3 спальни, сауна, гостиная и терраса площадью по 40м.кв. и большая площадь остекления - рецепт комфортного отдыха за городом.",
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