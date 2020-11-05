using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace MobilDogrulamaAPI
{
    public class Kategoriler
    {
        /// <summary>
        /// MobilDogrulama.com üzerinde oluşturulmuş bütün Kategorileri getirir.
        /// Örnek: id:1, name: Google
        /// </summary>
        /// <returns></returns>
        public async Task<List<Class.Kategori>> KategorileriGetir()
        {
            List<Class.Kategori> _Kategoriler = new List<Class.Kategori>();
            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            try
            {
                string url = "http://mobildogrulama.com/api/getCategories";

                using (HttpClient client = new HttpClient())
                {
                    using (HttpResponseMessage response = await client.GetAsync(url))
                    {
                        string responseBody = await response.Content.ReadAsStringAsync();

                        if (response.IsSuccessStatusCode)
                        {
                            _Kategoriler = JsonConvert.DeserializeObject<List<Class.Kategori>>(responseBody);
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
            return _Kategoriler;
        }
    }
}
