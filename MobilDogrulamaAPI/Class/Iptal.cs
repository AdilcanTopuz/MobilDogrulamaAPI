using Newtonsoft.Json; 

namespace MobilDogrulamaAPI.Class
{
    public partial class Iptal
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        public override string ToString()
        {
            return $"Success: {this.Success}\nTitle:{this.Title}\nMessage:{this.Message}";
        }
    }
}
