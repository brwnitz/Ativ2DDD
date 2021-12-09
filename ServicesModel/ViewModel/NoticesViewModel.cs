using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ServicesModel.ViewModel
{
    public class NoticesViewModel
    {
        [JsonPropertyName("PublicationDate")]
        public string PublicationDate { get; set; }

        [JsonPropertyName("Type")]
        public string Type { get; set; }

        [JsonPropertyName("EventDate")]
        public string EventDate { get; set; }

        [JsonPropertyName("Category")]
        public string Category { get; set; }

        [JsonPropertyName("PubDescription")]
        public string PubDescription { get; set; }

    }
}
