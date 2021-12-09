using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ServicesModel.ViewModel
{
    public class PostViewModel
    {
        [JsonPropertyName("PostDate")]
        public string PostDate { get; set; }

        [JsonPropertyName("Likes")]
        public int Likes { get; set; }

        [JsonPropertyName("Dislikes")]
        public int Dislikes { get; set; }

        [JsonPropertyName("Commentaries")]
        public string Commentaries { get; set; }

        [JsonPropertyName("Description")]
        public string Description { get; set; }

        [JsonPropertyName("Id Usuario")]
        public int UserId { get; set; }

        [JsonPropertyName("Usuario")]
        public PostViewModel User { get; set; }
    }
}
