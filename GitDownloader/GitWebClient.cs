using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using RestSharp;

namespace GitDownloader
{
    public class GitWebClient
    {
       
        //private static string _baseUrl = "https://github.com/TauLabs/TauLabs/tree/next/shared/uavobjectdefinition";

        public static string WebRequest(string baseUrl, string resource, string method, IEnumerable<Tuple<string, string>> requestParams, IEnumerable<Tuple<string, string>> requestHeaders = null)
        {
            var client = new RestClient(baseUrl)
            {
                UserAgent =
                    @"Mozilla/5.0 (Windows NT 6.3; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/41.0.2272.89 Safari/537.36"
            };
            Method meth;
            Enum.TryParse(method, out meth);

            var request = new RestRequest(resource, meth);

            if (requestParams != null)
                foreach (var arg in requestParams)
                {
                    request.AddParameter(arg.Item1, arg.Item2);
                }

            if (requestHeaders != null)
            {
                foreach (var arg in requestHeaders)
                {
                    request.AddHeader(arg.Item1, arg.Item2);
                }
            }

            var response = client.Execute(request);

            var cookiecon = new CookieContainer();

            if (response.StatusCode == HttpStatusCode.OK)
            {
                var cookie = response.Cookies.FirstOrDefault();
                if (cookie != null) cookiecon.Add(new Cookie(cookie.Name, cookie.Value, cookie.Path, cookie.Domain));
            }

            client.CookieContainer = cookiecon;

            return response.Content;
        }
    }
}
