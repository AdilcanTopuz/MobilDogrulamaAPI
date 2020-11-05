using Newtonsoft.Json; 

namespace MobilDogrulamaAPI.Class
{
    public partial class Siparis
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("number_id")]
        public long NumberId { get; set; }

        [JsonProperty("number")]
        public string Number { get; set; }

        public override string ToString()
        {
            return $"Success: {this.Success}\nTitle:{this.Title}\nMessage:{this.Message}\nNumber ID:{this.NumberId}\nNumber:{this.Number}";
        }
    }
}
