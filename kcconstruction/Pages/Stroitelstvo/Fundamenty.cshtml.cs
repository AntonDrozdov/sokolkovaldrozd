using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using kcconstruction.Web.ViewModels;
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
                    },
                    Region = "Ленинградская область",
                    CommonProperties = "Строительство утепленного шведского фундамента (УШП) в Гатчине. " +
                                       "Классический вариант современного решения фундамента для индивидуального жилого дома. " +
                                       "Данный тип фундамента совмещает в себе комплекс функциональных возможностей, что позволяет решить за один прием сразу " +
                                       "несколько задач - во время строительства фундамента закрывается вопрос по отоплению, канализации и водоснабжению дома. " +
                                       "Данный фундамент возводился на участке с высоким уровнем грунтовых вод, что обязало нас озаботиться обширной дренажной сетью. " +
                                       "Ведь отведение воды из под фундамента - важнейшая задача. Площадь плиты составила 75м.кв. " +
                                       "Срок реализации с учетом подготовки учатка - 4 недели. " +
                                       "Данный объект был в работе летом 2018 года.",
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
                    Name="melkozaglublennyplotnysosnovo",
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
                        "/images/Stroitelstvo/Fundamenty/Pjatireche_fundament/FP_010_sm.jpg"
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
                        "/images/Stroitelstvo/Fundamenty/Pjatireche_fundament/FP_010.jpg"
                    },
                    FullCycleLink = "Proektirovanie/Fundamenty",
                    Region = "Ленинградская область",
                    CommonProperties = "Монтаж монолитного железобетонного фундамента под дом из клееного бруса близ пос.Сосново Приозерского района был осуществлен в мае 2018 года. " +
                                       "Фундамент - плита толщиной 200мм с ребрами 200х500мм вниз. " +
                                       "Инженерно-геологические условия на участке оказались далеко не самыми плохими, " +
                                       "но все же было принято решение осуществить полную замену коренного грунта под пятном застройки на чистый строительный песок. " +
                                       "Сделано это, в первую очередь, для уверенности в однородности слоя грунта, на который опирается фундамент." +
                                       "Монолитная конструкция была утеплена по всему периметру. " +
                                       "Также вокруг пятна застройки были смотнтированы дренажная система и ливневая канализация. " +
                                       "Помимо работ по возведению фундамента, на участке был выполнен комплекс работ по усилению печаного склона, примыкающего к дороге общего пользования.",
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