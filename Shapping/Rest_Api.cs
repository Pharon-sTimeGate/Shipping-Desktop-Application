using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Net.Http;
using System.Net.Http.Formatting;

using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace Shapping.Classes
{
    public static class Rest_Api
    {
        private static readonly string baseURL = "https://reqres.in/api/";
        public static async Task<string> GetALL()
        {
            using (HttpClient client = new HttpClient())
            {

              //      string s = "http://nabilmokhtar.pythonanywhere.com/Items/ItemsAPI/";

                using (HttpResponseMessage res = await client.GetAsync("http://nabilmokhtar.pythonanywhere.com/Items/ItemsAPI/"))
                {

                    using (HttpContent content = res.Content)
                    {

                        string data = await content.ReadAsStringAsync();
                        if (data != null)
                        {
                            return data;
                        }
                    }

                }

            }
            return string.Empty;

        }




        public static string spliting(string str)
        {
            JToken parse = JToken.Parse(str);
            return parse.ToString(Formatting.Indented);
        }

        public static async Task<string> Get(string id)
        {
            using (HttpClient client = new HttpClient())
            {

                using (HttpResponseMessage res = await client.GetAsync(baseURL + "users/" + id))
                {

                    using (HttpContent content = res.Content)
                    {

                        string data = await content.ReadAsStringAsync();
                        if (data != null)
                        {
                            return data;
                        }
                    }

                }

            }
            return string.Empty;

        }


        public static async Task<string> Post(string name, string job)
        {

            var input_data = new Dictionary<string, string>
            {
                {"name",name},
                {"job",job}
            };

            var input = new FormUrlEncodedContent(input_data);


            using (HttpClient client = new HttpClient())
            {

                using (HttpResponseMessage res = await client.PostAsync(baseURL + "users", input))
                {

                    using (HttpContent content = res.Content)
                    {

                        string data = await content.ReadAsStringAsync();
                        if (data != null)
                        {
                            return data;
                        }
                    }

                }

            }
            return string.Empty;

        }


        public static async Task<string> PUT_update(string id, string name, string job)
        {

            var input_data = new Dictionary<string, string>
            {
                {"name",name},
                {"job",job}
            };

            var input = new FormUrlEncodedContent(input_data);


            using (HttpClient client = new HttpClient())
            {

                using (HttpResponseMessage res = await client.PutAsync(baseURL + "users/" + id, input))
                {


                    using (HttpContent content = res.Content)
                    {

                        string data = await content.ReadAsStringAsync();
                        if (data != null)
                        {
                            return data;
                        }
                    }

                }

            }
            return string.Empty;

        }


        








    }
}
