using Newtonsoft.Json;

namespace MobilDogrulamaAPI.Class
{
    public partial class Kategori
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
        public override string ToString()
        {
            return $"Id: {this.Id}\nName:{this.Name}";
        }
    }
}
