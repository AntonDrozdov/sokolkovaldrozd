using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using kcconstruction.Web.ViewModels;
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
                    CommonProperties = "Реализация каркасного дома в стиле Фрейм-хаус в Разметелево. " +
                                       "Строительство этого дома производилось летом 2018-го года. " +
                                       "Безусловно, и с архитектурной, и с конструктивной точек зрения, проект является уникальным для нашего региона. " +
                                       "Все конструкции собраны из сухого строганого пиломатериала. " +
                                       "В составе конструкций применены самые современные и качественные материалы и решения, что гарантирует высокий комфорт проживания и эксплуатации. " +
                                       "Толщина утепления стен минераловатным утеплителем составила 250мм, крыши - 300мм. " +
                                       "Большое количество клееных и гнутоклееных элементов, выполняющих как несущую конструктивную, так и декоративную роли, придало этому дому поистине завершенный и стильный внешний вид.",
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
                    CommonProperties = "Данная баня, стоящая на одном участке с Каркасным домом в стиле <a class=\"kc-inlinelink\" href=\"/Stroitelstvo/KarkasnyeDoma#karkasfreinhausrazmetelevoAnchor\">\"Фрейм-Хаус\"</a> в Разметелево, " +
                                       "попала к нам в работу на этапе отделки. " +
                                       "Задача стояла одна - внешняя отделка. " +
                                       "Был произведен монтаж имитатора бруса, декоративный элементов, обрамления окон и подшивки свесов. " +
                                       "Декоративные элементы из клееного бруса пересекаются с конструктивом основного дома, создавая единый ансамбль.",
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
                    CommonProperties = "Двухэтажный каркасный дом в Рощино - один из самых первых проектов, " +
                                       "реализованных руками людей, которые сегодня работают в нашей команде. " +
                                       "Архитектура дома была выбрана Заказчиком из финского каталога и предложена нам для разработки КД и реализации. " +
                                       "Строительство дома было осуществлено летом 2006 года. " +
                                       "Многие технические решения, которые можно увидеть на фотографиях, " +
                                       "на сегодняшний день считаются неактуальными или устаревшими, но дом успешно эксплатируется уже 12 лет и никаких нареканий его состояние не вызывает.",
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
                    CommonProperties = "Индивидуальный жилой дом в пос.Сосново Приозерского района. " +
                                       "Дом построен по каркасной технологии из сухой строганой доски с применением балок из клееного бруса. " +
                                       "Толщина утепления стен составила 200мм, кровли 250мм. " +
                                       "Фундамент - монолитная железобетонная плита. " +
                                       "Из особенностей данного проекта можно отметить эркер, кровлей которого выступает гидроизолированный балкон. " +
                                       "Подобные комбинации должны быть очень тщательно спроектированы и смонтированы. " +
                                       "Срок строительства дома на готовый фундамент в комплектации \"Теплый контур\" составил 4.5 месяца.",
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
                    CommonProperties = "Работы по возведению каркаса на данном объекте производились в июне 2018 года." +
                                       "На переданный Заказчиком фундамент из буронабивных свай, обвязанный брусом 200х200мм, был смонтирован комплект конструкций. " +
                                       "Цокольное перекрытие - одинарные двойные лаги 45х195мм. " +
                                       "Наружные стены 45х195мм." +
                                       "Внутренние перегородки 45х145мм." +
                                       "Стропильная система 45х195мм по клеёным балкам 140х350мм." +
                                       "Каркас на 100% собран из сухого строганного Пиломатериала на оцинкованный крепёж." +
                                       "В 2018 году также были произведены работы по монтажу ветровлагозащитной плиты Белтермо 200мм, " +
                                       "поверх которой нанесена мембрана Tyvek для лучшей защиты от продувания (дом стоит в 100м от береговой линии). " +
                                       "Монтаж мягкой черепицы Shinglas производился параллельно с работами по монтажу Белтермо. " +
                                       "Перечисленный комплекс работ занял 6 недель.",
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