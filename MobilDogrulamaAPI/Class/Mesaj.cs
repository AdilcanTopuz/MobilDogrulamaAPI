using Newtonsoft.Json; 

namespace MobilDogrulamaAPI.Class
{
    public partial class Mesaj
    {
        [JsonProperty("code")]
        public object Code { get; set; }

        [JsonProperty("id")] 
        public long Id { get; set; }

        [JsonProperty("status")]
        public long Status { get; set; }
        public override string ToString()
        {
            return $"Code: {this.Code}\nId: {this.Id}\nStatus: {this.Status}";
        }
    }
}
