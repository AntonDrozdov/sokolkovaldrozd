using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using kcconstruction.Web.ViewModels;
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
                    Title = "Мансандра на Фонтаке в Санкт-Петербурге",
                    Name = "mansardanafontanke_prj",
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
                    },
                    Region = "Санкт-Петербург",
                    CommonProperties = "Проект стропильной системы мансарды. " +
                                       "Данная конструкция была применена при реконструкции мансардного этажа здания на набережной Фонтанки. " +
                                       "Уникальность конструкции заключается в том, что она разработана с учетом необходимости монтажа без демонтажа существующего кровельного покрытия.",
                    BuildingType = "",
                    Technology = "",
                    FundamentType = "",
                    Floor = "",
                    Sizes = "",
                    Square = "",

                },
                new GallerySnippetViewModel
                {
                    Title = "Крыша гаража со стропильными фермами в Кировске",
                    Name = "kryshasostropkirovsk",
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
                    },
                    FullCycleLink= "Stroitelstvo/StropilnyeSistemy",
                    Region = "Кировск",
                    CommonProperties = "Проект стропильной системы частного гаража. " +
                                       "Для перекрытия пролета 6м применены стропильные фермы нашего производства. " +
                                       "Фермы собраны из сухой строганой доски с фанерными накладками. " +
                                       "Данное решение позволяет выполнить работы в сжатые сроки с минимальным бюджетом.",
                    BuildingType = "",
                    Technology = "",
                    FundamentType = "",
                    Floor = "",
                    Sizes = "",
                    Square = "",
                    IsFullCycled = true
                },
                new GallerySnippetViewModel
                {
                    Title = "Мансарда на ул. Казанская в Санкт-Петербурге",
                    Name = "mansardakazanskayaspb_prj",
                    PathToImagesSm = new List<string>
                    {
                        "/images/Proektirovanie/StropilnyeSistemy/SK3/SK3_001_sm.jpg",
                        "/images/Proektirovanie/StropilnyeSistemy/SK3/SK3_004_sm.jpg",
                        "/images/Proektirovanie/StropilnyeSistemy/SK3/SK3_002_sm.jpg",
                        "/images/Proektirovanie/StropilnyeSistemy/SK3/SK3_003_sm.jpg",
                        "/images/Proektirovanie/StropilnyeSistemy/SK3/SK3_005_sm.jpg",
                        "/images/Proektirovanie/StropilnyeSistemy/SK3/SK3_006_sm.jpg",
                        "/images/Proektirovanie/StropilnyeSistemy/SK3/SK3_007_sm.jpg",
                    },
                    PathToImages = new List<string>
                    {
                        "/images/Proektirovanie/StropilnyeSistemy/SK3/SK3_001.jpg",
                        "/images/Proektirovanie/StropilnyeSistemy/SK3/SK3_002.jpg",
                        "/images/Proektirovanie/StropilnyeSistemy/SK3/SK3_003.jpg",
                        "/images/Proektirovanie/StropilnyeSistemy/SK3/SK3_004.jpg",
                        "/images/Proektirovanie/StropilnyeSistemy/SK3/SK3_005.jpg",
                        "/images/Proektirovanie/StropilnyeSistemy/SK3/SK3_006.jpg",
                        "/images/Proektirovanie/StropilnyeSistemy/SK3/SK3_007.jpg",
                    },
                    Region = "Санкт-Петербург",
                    CommonProperties = "Проект реконструкции стропильной системы в старом фонде. " +
                                       "Основной задачей при проектировании данного объекта была возможность осуществить монтаж несущик конструкций без демонтажа существующего кровлельного покртыя. " +
                                       "Поэтому пришлось искуственно разрезать балки и добавлять дополнительные узлы. " +
                                       "В итоге, благодаря тому что в конструкции применены современные клееные деревянные конструкции и узловые решения, задача была успешно решена.",
                    BuildingType = "",
                    Technology = "",
                    FundamentType = "",
                    Floor = "",
                    Sizes = "",
                    Square = "",
                },
                new GallerySnippetViewModel
                {
                    Title = "Мансардный этаж загородного особняка",
                    Name = "mansardnyietazhzagorodnogoosobnyaka",
                    PathToImagesSm = new List<string>
                    {
                        "/images/Proektirovanie/StropilnyeSistemy/SK4/SK4_001_sm.jpg",
                        "/images/Proektirovanie/StropilnyeSistemy/SK4/SK4_004_sm.jpg",
                        "/images/Proektirovanie/StropilnyeSistemy/SK4/SK4_002_sm.jpg",
                        "/images/Proektirovanie/StropilnyeSistemy/SK4/SK4_003_sm.jpg",
                        "/images/Proektirovanie/StropilnyeSistemy/SK4/SK4_005_sm.jpg",
                        "/images/Proektirovanie/StropilnyeSistemy/SK4/SK4_006_sm.jpg",
                        "/images/Proektirovanie/StropilnyeSistemy/SK4/SK4_007_sm.jpg",
                    },
                    PathToImages = new List<string>
                    {
                        "/images/Proektirovanie/StropilnyeSistemy/SK4/SK4_001.jpg",
                        "/images/Proektirovanie/StropilnyeSistemy/SK4/SK4_002.jpg",
                        "/images/Proektirovanie/StropilnyeSistemy/SK4/SK4_003.jpg",
                        "/images/Proektirovanie/StropilnyeSistemy/SK4/SK4_004.jpg",
                        "/images/Proektirovanie/StropilnyeSistemy/SK4/SK4_005.jpg",
                        "/images/Proektirovanie/StropilnyeSistemy/SK4/SK4_006.jpg",
                        "/images/Proektirovanie/StropilnyeSistemy/SK4/SK4_007.jpg",
                    },
                    Region = "Ленинградская область",
                    CommonProperties = "Проект мансардного этажа загородного каменного особняка." +
                                       "Площадь этажа - 380м.кв. Основные Конструкции мансарды выполнены из LVL бруса по принципу трехшарнирной рамы пролетом 9,5м и 12,4м. " +
                                       "Жесткие опорные узлы с креплением к основанию на химические анкера hilti , диагональные металлические связи по всей плоскости кровли. " +
                                       "В проекте применено порядка 35м.куб. LVL бруса и 4 тонны индивидуальных металлических деталей. " +
                                       "Немного подробнее об основных конструктивных решениях в проекте: " +
                                       "(1)Основой конструктивной схемы мансардного этажа являются трехшарнирные рамы на жестких карнизных узлах. " +
                                       "В данных узлах соединение выполнено на металлических нагелях, расположенных по окружности. " +
                                       "В качестве нагеля применена гладкая оцинкованная арматура диаметром 20мм с нарезкой резьбы только на концевых частях, для повышения несущей способности соединения. " +
                                       "(2)Опорный узел рамы - шарнир. " +
                                       "Из-за невозможности применения достаточного количества анкерных болтов для восприятия распорного усилия рамы, на закладной металлической детали выполнена упорная пятка, под которую в бетоне заранее подготавливалась штроба. " +
                                       "Химические анкеры применены для фиксации деталей на время монтажа. " +
                                       "Закладные металлические детали выполнены из стали марки С235 с термодифузионным цинкованием.",
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