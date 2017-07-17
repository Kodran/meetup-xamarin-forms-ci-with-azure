using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Xamarin.Service
{
    public class Service : IService
    {
        private static string apiUrl = "https://api-xamarin-mup.azurewebsites.net/api/";
        private static string customerPath = "customer";

        public async Task<List<string>> GetCustomerAll()
        {
            using (var client = new HttpClient())
            {
                var response = await client.GetAsync(apiUrl + customerPath);
                var result = new List<string>();
                if (response.IsSuccessStatusCode)
                {
                    var customers = await response.Content.ReadAsStringAsync();
                    result = JsonConvert.DeserializeObject<List<string>>(customers);
                }

                return result;
            }
        }
    }
}
