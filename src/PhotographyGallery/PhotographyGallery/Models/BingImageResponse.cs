using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace PhotographyGallery.Models
{

    public class BingImageResponse
    {
        [JsonProperty(PropertyName = "_type")]
        public string _type { get; set; }
        [JsonProperty(PropertyName = "value")]
        public BingImage[] value { get; set; }
    }

    public class BingImage
    {
        [JsonProperty(PropertyName = "name")]
        public string name { get; set; }
        [JsonProperty(PropertyName = "webSearchUrl")]
        public string webSearchUrl { get; set; }
        [JsonProperty(PropertyName = "webSearchUrlPingSuffix")]
        public string webSearchUrlPingSuffix { get; set; }
        [JsonProperty(PropertyName = "thumbnailUrl")]
        public string thumbnailUrl { get; set; }
        [JsonProperty(PropertyName = "datePublished")]
        public DateTime datePublished { get; set; }
        [JsonProperty(PropertyName = "contentUrl")]
        public string contentUrl { get; set; }
        [JsonProperty(PropertyName = "hostPageUrl")]
        public string hostPageUrl { get; set; }
        [JsonProperty(PropertyName = "hostPageUrlPingSuffix")]
        public string hostPageUrlPingSuffix { get; set; }
        [JsonProperty(PropertyName = "contentSize")]
        public string contentSize { get; set; }
        [JsonProperty(PropertyName = "encodingFormat")]
        public string encodingFormat { get; set; }
        [JsonProperty(PropertyName = "hostPageDisplayUrl")]
        public string hostPageDisplayUrl { get; set; }
        [JsonProperty(PropertyName = "width")]
        public int width { get; set; }
        [JsonProperty(PropertyName = "height")]
        public int height { get; set; }
        [JsonProperty(PropertyName = "thumbnail")]
        public Thumbnail thumbnail { get; set; }
        [JsonProperty(PropertyName = "imageId")]
        public string imageId { get; set; }
        [JsonProperty(PropertyName = "accentColor")]
        public string accentColor { get; set; }
    }

    public class Thumbnail
    {
        [JsonProperty(PropertyName = "width")]
        public int width { get; set; }
        [JsonProperty(PropertyName = "height")]
        public int height { get; set; }
    }

}