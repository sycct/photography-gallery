using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PhotographyGallery.Models;
using System.Net;
using System.IO;

namespace PhotographyGallery.Data
{
    public class BingRepository
    {
         public BingImage[] GetBingImages()
        {
            var results = new BingImage[] { };
            var webClient = new WebClient();
            webClient.Headers.Add("Ocp-Apim-Subscription-Key", "018b48326ce247919bd60c3121812766");
            byte[] searchResults = webClient.DownloadData(string.Format("https://api.cognitive.microsoft.com/bing/v5.0/images/search?q={0}&mkt=en-us", "rocky+mountains&count=8"));
            var serializer = new JsonSerializer();
            using (var stream = new MemoryStream(searchResults))
            using (var reader = new StreamReader(stream))
            using (var jsonReader = new JsonTextReader(reader))
            {
                return results = serializer.Deserialize<BingImageResponse>(jsonReader).value;
            }
        }
    }
}