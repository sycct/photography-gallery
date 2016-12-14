using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PhotographyGallery.Models
{
    public class Photo
    {
        public string DisplayText { get; set; }
        public string Description { get; set; }
        public string FilePath { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }


    }
}