using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace URLShortenerTestProject.UnitTests
{
    class URLShortenerTest
    {
        List<URLShortener.Models.Url> urls;

        [SetUp]
        public void Setup()
        {
            urls = new List<URLShortener.Models.Url>();
            urls.Add(new URLShortener.Models.Url() { UrlCode = 1, UrlShortened = "3af3c14996e54", UrlOriginal = "https://www.amazon.com/dp/B07YNLBS7R/ref=gw_ods_d_qc_sd_v2_en?pf_rd_r=4Y264BTQ474JJEZ50J59&pf_rd_p=51022686-cacf-4685-be9b-aa2b5d7b93c2" });
        }

        [Test]
        public void URLShortener_WhenInput_ReturnsShortenedURL()
        {
            String originalUrl = "https://www.amazon.com/dp/B07YNLBS7R/ref=gw_ods_d_qc_sd_v2_en?pf_rd_r=4Y264BTQ474JJEZ50J59&pf_rd_p=51022686-cacf-4685-be9b-aa2b5d7b93c2";   
            URLShortener.Logic.URLShortenerService uRLShortenerService = new URLShortener.Logic.URLShortenerService(originalUrl, null);            
            String shortenedUrl = uRLShortenerService.shortenUrl();
            int originalUrlLenght = originalUrl.Length;
            int shortenedUrlLength = shortenedUrl.Length;
            Assert.That(shortenedUrlLength, Is.LessThan(originalUrlLenght));
        }

        [Test]
        public void URLShortener_WhenGenerated_CheckIfUnique()
        {
            string originalUrl = urls.First().UrlShortened;
            URLShortener.Logic.URLShortenerService uRLShortenerService = new URLShortener.Logic.URLShortenerService(originalUrl, null);
            String shortenedUrl = uRLShortenerService.shortenUrl();
            Assert.AreNotEqual(originalUrl, shortenedUrl);
        }

        [Test]
        public void URLShortener_WhenInputShortened_ReturnsOriginalURL()
        {
            String shortenedUrl = "3af3c14996e54";
            URLShortener.Logic.URLShortenerService uRLShortenerService = new URLShortener.Logic.URLShortenerService(null, urls);
            string originalUrl = uRLShortenerService.returnOriginalUrlFromShortened(shortenedUrl);
            int originalUrlLenght = originalUrl.Length;
            int shortenedUrlLength = shortenedUrl.Length;
            Assert.That(originalUrlLenght, Is.GreaterThan(shortenedUrlLength));
        }

        [Test]
        public void URLShortener_List_ReturnsStatsTop10()
        {

            Assert.Pass();
        }
    }
}
