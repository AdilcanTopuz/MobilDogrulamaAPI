using Newtonsoft.Json;

namespace MobilDogrulamaAPI.Class
{
    public partial class Servis
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("category")]
        public long Category { get; set; }
        public override string ToString()
        {
            return $"Id: {this.Id}\nName:{this.Name}\nCategory:{this.Category}";
        }
    }
}
