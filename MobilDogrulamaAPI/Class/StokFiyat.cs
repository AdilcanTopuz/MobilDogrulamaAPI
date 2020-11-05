using Newtonsoft.Json; 

namespace MobilDogrulamaAPI.Class
{
    public partial class StokFiyat
    {
        [JsonProperty("id")] 
        public long Id { get; set; }

        [JsonProperty("price")] 
        public long Price { get; set; }

        [JsonProperty("stock")]
        public long Stock { get; set; }
        public override string ToString()
        {
            return $"Id: {this.Id}\nPrice:{this.Price}\nStock:{this.Stock}";
        }
    }
}
