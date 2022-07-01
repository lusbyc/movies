using System;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net.Http;
using System.Net.Http.Headers;

namespace interview
{
    class Program
    {
        static void Main(string[] args)
        {

            StreamReader r = new StreamReader(@"/Users/cashmere/DevProjects/Movies/lusbyc-parse-and-post-aom/movies.json");
            string jsonString = r.ReadToEnd();


            JArray a = JArray.Parse(jsonString);

            foreach (JObject item in a)
            {
                string year = item.GetValue("year").ToString();
                string length = item.GetValue("length").ToString();
                string title = item.GetValue("title").ToString();
                string subject = item.GetValue("subject").ToString();
                string actor = item.GetValue("actor").ToString();
                string actress = item.GetValue("actress").ToString();
                string director = item.GetValue("director").ToString();
                string popularity = item.GetValue("popularity").ToString();
                string awards = item.GetValue("awards").ToString();
                string image = item.GetValue("image").ToString();

                string url = "http://localhost:9009/movies -d ";
                string request = "{year: " + year + ", length: " + length + ", title: " + title + ", subject: " + subject + ", actor: " + actor + ", actress: " + actress + ", director: " + director + ", popularity: " + popularity + ", awards: " + awards + ", image: " + image + "}";

                string postRequest = url + request;
                Console.WriteLine(postRequest);


            }
        }
    }

}