using Newtonsoft.Json; 

namespace MobilDogrulamaAPI.Class
{
    public partial class Bakiye
    {
        [JsonProperty("balance")] 
        public long Balance { get; set; }
        public override string ToString()
        {
            return $"Balance: {this.Balance}";
        }
    }
}
