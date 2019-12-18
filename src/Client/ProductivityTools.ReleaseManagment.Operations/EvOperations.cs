using ProductivityTools.ReleaseManagment.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ProductivityTools.ReleaseManagment.Operations
{
    public class EvOperations
    {
        static HttpClient client = new HttpClient();
        static EvOperations()
        {
            //pw:change
            client.BaseAddress = new Uri("https://localhost:44323/");
        }
        

        private async Task<T> HttpGet<T>(string path)
        {
            T result = default(T);
            HttpResponseMessage response = await client.GetAsync($"api/general/{path}");
            if (response.IsSuccessStatusCode)
            {
                result = await response.Content.ReadAsAsync<T>();
            }
            return result;
        }

        public ReleaseInfo GetReleaseInfo()
        {
            var x=HttpGet<ReleaseInfo>(MethodNames.GetReleaseInfo);
            return x.Result;
        }

        public List<Schedule> GetSprints()
        {
            var x = HttpGet<List<Schedule>>(MethodNames.GetSprints);
            return x.Result;
        }
    }
}
