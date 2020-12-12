using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace URLShortener.Logic
{
    public class URLShortenerService
    {
        string originalUrl { get; set; }
        List<URLShortener.Models.Url> urls;
        public URLShortenerService(string _originalUrl, List<URLShortener.Models.Url> _urls)
        {
            this.originalUrl = _originalUrl;
            this.urls = _urls;
        }

        public string shortenUrl()
        {
            var ticks = new DateTime(2019, 1, 1).Ticks;
            var diff = DateTime.Now.Ticks - ticks;
            var uniqueId = diff.ToString("x");
            return uniqueId;
        }

        public string returnOriginalUrlFromShortened(string shortenedUrl)
        {
            URLShortener.Models.Url url = urls.FirstOrDefault(x => x.UrlShortened == shortenedUrl);
            return url.UrlOriginal;
        }
    }
}
