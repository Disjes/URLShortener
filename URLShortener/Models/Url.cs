using System;
using System.Collections.Generic;

#nullable disable

namespace URLShortener.Models
{
    public partial class Url
    {
        public int UrlCode { get; set; }
        public string UrlShortened { get; set; }
        public string UrlOriginal { get; set; }
        public int? UrlTimesVisited { get; set; }
        public string UrlTitle { get; set; }
    }
}
