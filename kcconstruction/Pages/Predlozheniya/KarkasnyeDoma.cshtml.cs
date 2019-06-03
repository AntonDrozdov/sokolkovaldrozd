using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using kcconstruction.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace kcconstruction.Pages.Predlozheniya
{
    public class KarkasnyeDomaModel : PageModel
    {
        public List<PredlozhenieSnippetViewModel> Predlosheniya = new List<PredlozhenieSnippetViewModel>();
        public void OnGet()
        {
            Predlosheniya.AddRange(new List<PredlozhenieSnippetViewModel>
            {
                new PredlozhenieSnippetViewModel
                {
                    Title = "Проект одноэтажного дома КС-1",
                    Name = "PredlozhenieKC1",
                    PathToImagesSm = new List<string>
                    {
                        "/images/Predlozheniya/KarkasnyeDoma/KC1/KC1_001_sm.jpg",
                        "/images/Predlozheniya/KarkasnyeDoma/KC1/KC1_002_sm.jpg",
                        "/images/Predlozheniya/KarkasnyeDoma/KC1/KC1_004_sm.jpg",
                        "/images/Predlozheniya/KarkasnyeDoma/KC1/KC1_003_sm.jpg",
                        "/images/Predlozheniya/KarkasnyeDoma/KC1/KC1_005_sm.jpg",
                        "/images/Predlozheniya/KarkasnyeDoma/KC1/KC1_006_sm.jpg"
                    },
                    PathToImages = new List<string>
                    {
                        "/images/Predlozheniya/KarkasnyeDoma/KC1/KC1_001.jpg",
                        "/images/Predlozheniya/KarkasnyeDoma/KC1/KC1_002.jpg",
                        "/images/Predlozheniya/KarkasnyeDoma/KC1/KC1_003.jpg",
                        "/images/Predlozheniya/KarkasnyeDoma/KC1/KC1_004.jpg",
                        "/images/Predlozheniya/KarkasnyeDoma/KC1/KC1_005.jpg",
                        "/images/Predlozheniya/KarkasnyeDoma/KC1/KC1_006.jpg"
                    },
                    Region = "Ленинградская область",
                    CommonProperties =  "Проект КС-1. Компактный дом с площадью помещений 47м.кв.  " +
                                        "Планировочные решения рассчитаны на круглогодичное проживание семьи из 2 человек. " +
                                        "Спальня, санузел, просторная кухня-гостиная, бойлерная с отдельным входом и даже небольшое хозяйственное помещение - всё необходимое здесь есть. " +
                                        "Дом может выступать как главным на участке, так и использоваться в качестве гостевого или, популярного ныне варианта, дома родителей, дополняя основной дом. " +
                                        "Для дома выполнены все проектные работы и произведён расчёт сметы на строительство в комплектации для круглогодичного проживания. " +
                                        "Также его можно оптимизировать под летний вариант. ",
                    BuildingType = "",
                    Technology = "",
                    FundamentType = "",
                    Floor = "Одноэтажный",
                    Sizes = "",
                    Square = "47м2 ",
                    Price = "от 2,39 млн руб"

                },
                new PredlozhenieSnippetViewModel
                {
                    Title = "Проект одноэтажного дома КС-2",
                    Name = "PredlozhenieKC2",
                    PathToImagesSm = new List<string>
                    {
                        "/images/Predlozheniya/KarkasnyeDoma/KC2/KC2_001_sm.jpg",
                        "/images/Predlozheniya/KarkasnyeDoma/KC2/KC2_002_sm.jpg",
                        "/images/Predlozheniya/KarkasnyeDoma/KC2/KC2_004_sm.jpg",
                        "/images/Predlozheniya/KarkasnyeDoma/KC2/KC2_005_sm.jpg",
                        "/images/Predlozheniya/KarkasnyeDoma/KC2/KC2_003_sm.jpg",
                        "/images/Predlozheniya/KarkasnyeDoma/KC2/KC2_006_sm.jpg",
                        "/images/Predlozheniya/KarkasnyeDoma/KC2/KC2_008_sm.jpg",
                        "/images/Predlozheniya/KarkasnyeDoma/KC2/KC2_007_sm.jpg",
                        "/images/Predlozheniya/KarkasnyeDoma/KC2/KC2_009_sm.jpg"
                    },
                    PathToImages = new List<string>
                    {
                        "/images/Predlozheniya/KarkasnyeDoma/KC2/KC2_001.jpg",
                        "/images/Predlozheniya/KarkasnyeDoma/KC2/KC2_002.jpg",
                        "/images/Predlozheniya/KarkasnyeDoma/KC2/KC2_003.jpg",
                        "/images/Predlozheniya/KarkasnyeDoma/KC2/KC2_004.jpg",
                        "/images/Predlozheniya/KarkasnyeDoma/KC2/KC2_005.jpg",
                        "/images/Predlozheniya/KarkasnyeDoma/KC2/KC2_006.jpg",
                        "/images/Predlozheniya/KarkasnyeDoma/KC2/KC2_008.jpg",
                        "/images/Predlozheniya/KarkasnyeDoma/KC2/KC2_007.jpg",
                        "/images/Predlozheniya/KarkasnyeDoma/KC2/KC2_009.jpg"
                    },
                    Region = "Ленинграсдкая область",
                    CommonProperties = "Это второй дом из серии фирменных проектов — КС-2. " +
                                       "В этом доме комфортно разместится семья из 3-4 человек. " +
                                       "Площадь помещений составляет 79м.кв. " +
                                       "По своей архитектуре дом перекликается с проекжтом КС-1. " +
                                       "Двускатная крыша, простая прямоугольная форма, все линии предсказуемы и понятны. " +
                                       "Дом не стремится удивить необычными архитектурными решениями. Напротив, его изюминка в ненавязчивости. " +
                                       "Детская и мастер-спальня, кухня-гостиная с большими окнами, непременно 2 санузла, бойлерная с отдельным входом, полноценная кладовая. " +
                                       "Опционально кладовая может быть заменена на сауну. ",
                    BuildingType = "",
                    Technology = "",
                    FundamentType = "",
                    Floor = "Одноэтажный",
                    Sizes = "",
                    Square = "79м2",
                    Price = "от 3,67 млн руб"
                },
                                new PredlozhenieSnippetViewModel
                {
                    Title = "Проект одноэтажного дома КС-3",
                    Name = "PredlozhenieKC3",
                    PathToImagesSm = new List<string>
                    {
                        "/images/Predlozheniya/KarkasnyeDoma/KC3/KC3_001_sm.jpg",
                        "/images/Predlozheniya/KarkasnyeDoma/KC3/KC3_002_sm.jpg",
                        "/images/Predlozheniya/KarkasnyeDoma/KC3/KC3_005_sm.jpg",
                        "/images/Predlozheniya/KarkasnyeDoma/KC3/KC3_010_sm.jpg",
                        "/images/Predlozheniya/KarkasnyeDoma/KC3/KC3_003_sm.jpg",
                        "/images/Predlozheniya/KarkasnyeDoma/KC3/KC3_006_sm.jpg",
                        "/images/Predlozheniya/KarkasnyeDoma/KC3/KC3_007_sm.jpg",
                        "/images/Predlozheniya/KarkasnyeDoma/KC3/KC3_004_sm.jpg",
                        "/images/Predlozheniya/KarkasnyeDoma/KC3/KC3_009_sm.jpg",
                        "/images/Predlozheniya/KarkasnyeDoma/KC3/KC3_008_sm.jpg"
                        
                    },
                    PathToImages = new List<string>
                    {
                        "/images/Predlozheniya/KarkasnyeDoma/KC3/KC3_001.jpg",
                        "/images/Predlozheniya/KarkasnyeDoma/KC3/KC3_002.jpg",
                        "/images/Predlozheniya/KarkasnyeDoma/KC3/KC3_003.jpg",
                        "/images/Predlozheniya/KarkasnyeDoma/KC3/KC3_004.jpg",
                        "/images/Predlozheniya/KarkasnyeDoma/KC3/KC3_005.jpg",
                        "/images/Predlozheniya/KarkasnyeDoma/KC3/KC3_006.jpg",
                        "/images/Predlozheniya/KarkasnyeDoma/KC3/KC3_007.jpg",
                        "/images/Predlozheniya/KarkasnyeDoma/KC3/KC3_008.jpg",
                        "/images/Predlozheniya/KarkasnyeDoma/KC3/KC3_009.jpg",
                        "/images/Predlozheniya/KarkasnyeDoma/KC3/KC3_010.jpg"
                    },
                    Region = "Ленинграсдкая область",
                    CommonProperties = "Третий, самый большой (153м.кв. жилой площади), дом из линейки фирменных проектов каркасных домов. " +
                                       "Дом имеет полноценный второй этаж, и рассчитан на постоянное проживание семьи численностью 6-7 человек." +
                                       "На первом этаже, как и в других домах серии, разместились кухня-гостиная со вторым светом, хозяйственное и техническое помещения, санузел. " +
                                       "К этому набору добавилось жилое помещение, которое может стать спальней, кабинетом или небольшим спортзалом, из которого при помощи балконной двери можно организовать выход во двор! " +
                                       "Второй этаж - комфортная классика, украшенная вторым светом. " +
                                       "Полностью автономная мастер-спальня, и две просторные жилые комнаты. " +
                                       "Для планировки первого этажа есть ещё один вариант - гардеробная, также как в случае с кладовой в с КС-2, может быть заменена на сауну.",
                    BuildingType = "",
                    Technology = "",
                    FundamentType = "",
                    Floor = "Двухэтажный",
                    Sizes = "",
                    Square = "153м2",
                    Price = "от 5,78 млн руб"
                }
            });


        }
    }
}