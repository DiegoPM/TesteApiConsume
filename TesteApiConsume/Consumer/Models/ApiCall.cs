using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Consumer.Models
{
    public static class ApiCall
    {
        public static HttpResponseMessage Get(string ApiUrl)
        {
            HttpClient client = new HttpClient();
            var response = client.GetAsync(ApiUrl).Result;
            return response;
        }



        public static string Post(string ApiUrl, string postData = "")
        {

            var request = (HttpWebRequest)WebRequest.Create(ApiUrl);
            var data = Encoding.ASCII.GetBytes(postData);
            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = data.Length;
            using (var stream = request.GetRequestStream())
            {
                stream.Write(data, 0, data.Length);
            }
            var response = (HttpWebResponse)request.GetResponse();
            var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
            return responseString;
        }
    }
}
