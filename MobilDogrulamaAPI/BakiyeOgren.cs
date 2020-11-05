using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MobilDogrulamaAPI
{
    public class BakiyeOgren
    {
        /// <summary>
        /// MobilDogrulama.com üzerindeki Bakiyenizi getirir.
        /// Örnek: balance: 2
        /// </summary>
        /// <param name="ApiKey"></param>
        /// <returns></returns>
        public async Task<Class.Bakiye> BakiyeGetir(string ApiKey)
        {
            Class.Bakiye _Bakiye = new Class.Bakiye();
            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            try
            {
                string url = string.Concat("http://mobildogrulama.com/api/", ApiKey, "/getBalance");

                using (HttpClient client = new HttpClient())
                {
                    using (HttpResponseMessage response = await client.GetAsync(url))
                    {
                        string responseBody = await response.Content.ReadAsStringAsync();

                        if (response.IsSuccessStatusCode)
                        {
                            _Bakiye = JsonConvert.DeserializeObject<Class.Bakiye>(responseBody);
                        }
                        else
                        {
                            throw new Exception("İstek Tamamlanmadı.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return _Bakiye;
        }
    }
}
