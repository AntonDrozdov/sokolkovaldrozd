using System.Collections.Generic;
using kcconstruction.ViewModels;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace kcconstruction.Pages.Proektirovanie
{
    public class FahverkovyeDomaModel : PageModel
    {
        public List<GallerySnippetViewModel> Galleries = new List<GallerySnippetViewModel>();

        public void OnGet()
        {
            Galleries.AddRange(new List<GallerySnippetViewModel>
            {
                new GallerySnippetViewModel
                {
                    Title = "Фахверковый дом в Екатеренбурге",
                    Name="fachverkekat_prj",
                    PathToImagesSm = new List<string>
                    {
                        "/images/Proektirovanie/FahverkovyeDoma/FD1/FD1_001_sm.jpg",
                        "/images/Proektirovanie/FahverkovyeDoma/FD1/FD1_004_sm.jpg",
                        "/images/Proektirovanie/FahverkovyeDoma/FD1/FD1_002_sm.jpg",
                        "/images/Proektirovanie/FahverkovyeDoma/FD1/FD1_003_sm.jpg",
                        "/images/Proektirovanie/FahverkovyeDoma/FD1/FD1_005_sm.jpg",
                        "/images/Proektirovanie/FahverkovyeDoma/FD1/FD1_006_sm.jpg",
                        "/images/Proektirovanie/FahverkovyeDoma/FD1/FD1_007_sm.jpg"
                    },
                    PathToImages = new List<string>
                    {
                        "/images/Proektirovanie/FahverkovyeDoma/FD1/FD1_001.jpg",
                        "/images/Proektirovanie/FahverkovyeDoma/FD1/FD1_002.jpg",
                        "/images/Proektirovanie/FahverkovyeDoma/FD1/FD1_003.jpg",
                        "/images/Proektirovanie/FahverkovyeDoma/FD1/FD1_004.jpg",
                        "/images/Proektirovanie/FahverkovyeDoma/FD1/FD1_005.jpg",
                        "/images/Proektirovanie/FahverkovyeDoma/FD1/FD1_006.jpg",
                        "/images/Proektirovanie/FahverkovyeDoma/FD1/FD1_007.jpg"
                    },
                    Region = "Екатеренбург",
                    CommonProperties = "Проект индивидуального жилого дома. " +
                                       "Здание выполнено по современной технологии - фахверк. " +
                                       "В несущем каркасе применены рамы из клееного бруса пролетомпорядка 8м. " +
                                       "Это позволило освобовить внутреннее пространство от опор и применить масштабное безрамное остекление.",
                    BuildingType = "",
                    Technology = "",
                    FundamentType = "",
                    Floor = "",
                    Sizes = "",
                    Square = "",

                },
                new GallerySnippetViewModel
                {
                    Title = "Современный фахверковый дом",
                    Name ="sovremenfahverk_prj",
                    PathToImagesSm = new List<string>
                    {
                        "/images/Proektirovanie/FahverkovyeDoma/FD2/FD2_001_sm.jpg",
                        "/images/Proektirovanie/FahverkovyeDoma/FD2/FD2_004_sm.jpg",
                        "/images/Proektirovanie/FahverkovyeDoma/FD2/FD2_002_sm.jpg",
                        "/images/Proektirovanie/FahverkovyeDoma/FD2/FD2_003_sm.jpg",
                        "/images/Proektirovanie/FahverkovyeDoma/FD2/FD2_005_sm.jpg",
                        "/images/Proektirovanie/FahverkovyeDoma/FD2/FD2_006_sm.jpg",
                        "/images/Proektirovanie/FahverkovyeDoma/FD2/FD2_007_sm.jpg"
                    },
                    PathToImages = new List<string>
                    {
                        "/images/Proektirovanie/FahverkovyeDoma/FD2/FD2_001.jpg",
                        "/images/Proektirovanie/FahverkovyeDoma/FD2/FD2_002.jpg",
                        "/images/Proektirovanie/FahverkovyeDoma/FD2/FD2_003.jpg",
                        "/images/Proektirovanie/FahverkovyeDoma/FD2/FD2_004.jpg",
                        "/images/Proektirovanie/FahverkovyeDoma/FD2/FD2_005.jpg",
                        "/images/Proektirovanie/FahverkovyeDoma/FD2/FD2_006.jpg",
                        "/images/Proektirovanie/FahverkovyeDoma/FD2/FD2_007.jpg"
                    },
                    Region = "Ленинградская область",
                    CommonProperties = "Проект индивидуального жилого дома. " +
                                       "Классический фахверковый дом. Весь несущий каркас выполнен из конструктивного клееного бруса. " +
                                       "Cтоечно-балочная система играет как несущую, так и декоративную роль - брус окрашивается в заводских условиях в несколько слоев.",
                    BuildingType = "",
                    Technology = "",
                    FundamentType = "",
                    Floor = "",
                    Sizes = "",
                    Square = "",
                },
                new GallerySnippetViewModel
                {
                    Title = "Фахверковый дом с плоской крышей",
                    Name = "fahverksploskoykryshey_prj",
                    PathToImagesSm = new List<string>
                    {
                        "/images/Proektirovanie/FahverkovyeDoma/FD3/FD3_001_sm.jpg",
                        "/images/Proektirovanie/FahverkovyeDoma/FD3/FD3_002_sm.jpg",
                        "/images/Proektirovanie/FahverkovyeDoma/FD3/FD3_003_sm.jpg",
                        "/images/Proektirovanie/FahverkovyeDoma/FD3/FD3_004_sm.jpg",
                        "/images/Proektirovanie/FahverkovyeDoma/FD3/FD3_005_sm.jpg",
                        "/images/Proektirovanie/FahverkovyeDoma/FD3/FD3_006_sm.jpg",
                        "/images/Proektirovanie/FahverkovyeDoma/FD3/FD3_007_sm.jpg",
                        "/images/Proektirovanie/FahverkovyeDoma/FD3/FD3_008_sm.jpg",
                        "/images/Proektirovanie/FahverkovyeDoma/FD3/FD3_009_sm.jpg"
                    },
                    PathToImages = new List<string>
                    {
                        "/images/Proektirovanie/FahverkovyeDoma/FD3/FD3_001.jpg",
                        "/images/Proektirovanie/FahverkovyeDoma/FD3/FD3_002.jpg",
                        "/images/Proektirovanie/FahverkovyeDoma/FD3/FD3_003.jpg",
                        "/images/Proektirovanie/FahverkovyeDoma/FD3/FD3_004.jpg",
                        "/images/Proektirovanie/FahverkovyeDoma/FD3/FD3_005.jpg",
                        "/images/Proektirovanie/FahverkovyeDoma/FD3/FD3_006.jpg",
                        "/images/Proektirovanie/FahverkovyeDoma/FD3/FD3_007.jpg",
                        "/images/Proektirovanie/FahverkovyeDoma/FD3/FD3_008.jpg",
                        "/images/Proektirovanie/FahverkovyeDoma/FD3/FD3_009.jpg"
                    },
                    Region = "Ленинградская область",
                    CommonProperties = "Проект индивидуального жилого дома. " +
                                       "Проект выполнен по фахверковой технологии в стиле hi-tech. " +
                                       "Кубические очертания, плоская кровля и отсутсвие свесов - вот визитная карточка этого стиля. " +
                                       "Комплект констукций изготовлен на современном оборудовании HUNDEGGER.",
                    BuildingType = "",
                    Technology = "",
                    FundamentType = "",
                    Floor = "",
                    Sizes = "",
                    Square = "",
                },
                new GallerySnippetViewModel
                {
                    Title = "Компактный фахверковый дом в Ленинградской области",
                    Name = "kompacynyfahverkvLenobl_prj",
                    PathToImagesSm = new List<string>
                    {
                        "/images/Proektirovanie/FahverkovyeDoma/FD4/FD4_005_sm.jpg",
                        "/images/Proektirovanie/FahverkovyeDoma/FD4/FD4_001_sm.jpg",
                        "/images/Proektirovanie/FahverkovyeDoma/FD4/FD4_004_sm.jpg",
                        "/images/Proektirovanie/FahverkovyeDoma/FD4/FD4_002_sm.jpg",
                        "/images/Proektirovanie/FahverkovyeDoma/FD4/FD4_003_sm.jpg",
                        "/images/Proektirovanie/FahverkovyeDoma/FD4/FD4_006_sm.jpg",
                        "/images/Proektirovanie/FahverkovyeDoma/FD4/FD4_007_sm.jpg",
                        "/images/Proektirovanie/FahverkovyeDoma/FD4/FD4_008_sm.jpg"
                    },
                    PathToImages = new List<string>
                    {
                        "/images/Proektirovanie/FahverkovyeDoma/FD4/FD4_005.jpg",
                        "/images/Proektirovanie/FahverkovyeDoma/FD4/FD4_001.jpg",
                        "/images/Proektirovanie/FahverkovyeDoma/FD4/FD4_002.jpg",
                        "/images/Proektirovanie/FahverkovyeDoma/FD4/FD4_003.jpg",
                        "/images/Proektirovanie/FahverkovyeDoma/FD4/FD4_004.jpg",
                        "/images/Proektirovanie/FahverkovyeDoma/FD4/FD4_006.jpg",
                        "/images/Proektirovanie/FahverkovyeDoma/FD4/FD4_007.jpg",
                        "/images/Proektirovanie/FahverkovyeDoma/FD4/FD4_008.jpg"
                    },
                    Region = "Ленинградская область",
                    CommonProperties = "Проект индивидуального жилого дома. " +
                                       "Проект выполнен по классической технологии - фахверк. " +
                                       "Комплект констукций изготовлен на современном оборудовании HUNDEGGER. ",
                    BuildingType = "",
                    Technology = "",
                    FundamentType = "",
                    Floor = "",
                    Sizes = "",
                    Square = "",

                },
                new GallerySnippetViewModel
                {
                    Title = "Фахверковый дом премиум класса в Лемболово",
                    Name = "premiumfahverklembolovo_prj",
                    PathToImagesSm = new List<string>
                    {
                        "/images/Proektirovanie/FahverkovyeDoma/FD5/FD5_001_sm.jpg",
                        "/images/Proektirovanie/FahverkovyeDoma/FD5/FD5_004_sm.jpg",
                        "/images/Proektirovanie/FahverkovyeDoma/FD5/FD5_002_sm.jpg",
                        "/images/Proektirovanie/FahverkovyeDoma/FD5/FD5_003_sm.jpg",
                        "/images/Proektirovanie/FahverkovyeDoma/FD5/FD5_005_sm.jpg",
                        "/images/Proektirovanie/FahverkovyeDoma/FD5/FD5_006_sm.jpg",
                        "/images/Proektirovanie/FahverkovyeDoma/FD5/FD5_007_sm.jpg",
                        "/images/Proektirovanie/FahverkovyeDoma/FD5/FD5_008_sm.jpg"
                    },
                    PathToImages = new List<string>
                    {
                        "/images/Proektirovanie/FahverkovyeDoma/FD5/FD5_001.jpg",
                        "/images/Proektirovanie/FahverkovyeDoma/FD5/FD5_002.jpg",
                        "/images/Proektirovanie/FahverkovyeDoma/FD5/FD5_003.jpg",
                        "/images/Proektirovanie/FahverkovyeDoma/FD5/FD5_004.jpg",
                        "/images/Proektirovanie/FahverkovyeDoma/FD5/FD5_005.jpg",
                        "/images/Proektirovanie/FahverkovyeDoma/FD5/FD5_006.jpg",
                        "/images/Proektirovanie/FahverkovyeDoma/FD5/FD5_007.jpg",
                        "/images/Proektirovanie/FahverkovyeDoma/FD5/FD5_008.jpg"
                    },
                    Region = "Ленинградская область",
                    CommonProperties = "Проект индивидуального жилого дома. " +
                                       "Проект выполнен по фахверковой технологии в стиле hi-tech. " +
                                       "Уникальный по своему размаху и примененным решениям проект. " +
                                       "Исполинские балки высотой до 800мм в купе с безрамным остеклением составляют одновременно массивную и прозрачную конструкцию. " +
                                       "На сегодняшний день произвести подобные конструкции в России объективно способно только одно производство. " +
                                       "Комплект констукций изготовлен на современном оборудовании HUNDEGGER.",
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