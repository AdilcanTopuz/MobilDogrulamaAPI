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
    public class NumaraSiparis
    {
        /// <summary>
        /// MobilDogrulama.com üzerinden Numara Almanızı sağlar.
        /// </summary>
        /// <param name="ApiKey"></param>
        /// <param name="ServiceId"></param>
        /// <returns></returns>
        public async Task<Class.Siparis> NumaraAl(string ApiKey, int ServiceId)
        {
            Class.Siparis _Siparis = new Class.Siparis();
            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            try
            {
                string url = string.Concat("http://mobildogrulama.com/api/", ApiKey, "/getNumber/", ServiceId);

                using (HttpClient client = new HttpClient())
                {
                    using (HttpResponseMessage response = await client.GetAsync(url))
                    {
                        string responseBody = await response.Content.ReadAsStringAsync();

                        if (response.IsSuccessStatusCode)
                        {
                            _Siparis = JsonConvert.DeserializeObject<Class.Siparis>(responseBody);
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
            return _Siparis;
        }

        public async Task<Class.Mesaj> SmsOku(string ApiKey, int NumberId)
        {
            Class.Mesaj _Mesaj = new Class.Mesaj();
            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            try
            {
                string url = string.Concat("http://mobildogrulama.com/api/", ApiKey, "/getMessage/", NumberId);

                using (HttpClient client = new HttpClient())
                {
                    using (HttpResponseMessage response = await client.GetAsync(url))
                    {
                        string responseBody = await response.Content.ReadAsStringAsync();

                        if (response.IsSuccessStatusCode)
                        {
                            _Mesaj = JsonConvert.DeserializeObject<Class.Mesaj>(responseBody);
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
            return _Mesaj;
        }


        public async Task<Class.Iptal> NumaraIptal(string ApiKey, int NumberId)
        {
            Class.Iptal _Iptal = new Class.Iptal();
            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            try
            {
                string url = string.Concat("http://mobildogrulama.com/api/", ApiKey, "/cancelNumber/", NumberId);

                using (HttpClient client = new HttpClient())
                {
                    using (HttpResponseMessage response = await client.GetAsync(url))
                    {
                        string responseBody = await response.Content.ReadAsStringAsync();

                        if (response.IsSuccessStatusCode)
                        {
                            _Iptal = JsonConvert.DeserializeObject<Class.Iptal>(responseBody);
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
            return _Iptal;
        }
    }
}
