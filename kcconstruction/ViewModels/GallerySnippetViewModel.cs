using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kcconstruction.ViewModels
{
    public class GallerySnippetViewModel
    {
        public string Title { get; set; }
        public string Name { get; set; }
        public List<string> PathToImagesSm { get; set; }
        public List<string> PathToImages { get; set; }
    }
}
