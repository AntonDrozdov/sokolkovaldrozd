﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kcconstruction.ViewModels
{
    public class PredlozhenieSnippetViewModel
    {
        public string Title { get; set; }
        public string Name { get; set; }
        public List<string> PathToImagesSm { get; set; }
        public List<string> PathToImages { get; set; }
        public string Region { get; set; }
        public string CommonProperties { get; set; }
        public string BuildingType { get; set; }
        public string Technology { get; set; }
        public string FundamentType { get; set; }
        public string Floor { get; set; }
        public string Sizes { get; set; }
        public string Square { get; set; }
        public bool IsFullCycled { get; set; } = false;
        public string FullCycleLink { get; set; } = "/";
    }
}