using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using RestSharp;

namespace GitDownloader
{
    public class GitWebClient
    {
        //https://github.com/TauLabs/TauLabs/tree/next/shared/uavobjectdefinition
        //https://developer.github.com/v3/repos/contents/#get-contents

        //https://api.github.com/repos/TauLabs/TauLabs/contents/shared/uavobjectdefinition/windvelocityactual.xml?ref=next

        //curl -i https://api.github.com/repos/taulabs/taulabs/contents/shared/uavobjectdefinition
   //      {
   //"name": "windvelocityactual.xml",
   //"path": "shared/uavobjectdefinition/windvelocityactual.xml",
   //"sha": "de663561395f99c4a0f84941708c093c38d926b5",
   //"size": 638,
   //"url": "https://api.github.com/repos/TauLabs/TauLabs/contents/shared/uavobjectdefinition/windvelocityactual.xml?ref=next",
   //"html_url": "https://github.com/TauLabs/TauLabs/blob/next/shared/uavobjectdefinition/windvelocityactual.xml",
   //"git_url": "https://api.github.com/repos/TauLabs/TauLabs/git/blobs/de663561395f99c4a0f84941708c093c38d926b5",
   //"download_url": "https://raw.githubusercontent.com/TauLabs/TauLabs/next/shared/uavobjectdefinition/windvelocityactual.xml",
   //"type": "file",
   //"_links": {
   //  "self": "https://api.github.com/repos/TauLabs/TauLabs/contents/shared/uavobjectdefinition/windvelocityactual.xml?ref=next",
   //  "git": "https://api.github.com/repos/TauLabs/TauLabs/git/blobs/de663561395f99c4a0f84941708c093c38d926b5",
   //  "html": "https://github.com/TauLabs/TauLabs/blob/next/shared/uavobjectdefinition/windvelocityactual.xml"
   //}


        private static string _baseUrl = "https://github.com/TauLabs/TauLabs/tree/next/shared/uavobjectdefinition";
        private static string _signInResource = "/users/sign_in";

        //public static bool LogIn(string userName, string userId)
        //{

        //    if (_token != null && _token.RevitToken != null) return true;

        //    var requestParams = new List<Tuple<string, string>>()
        //    {
        //        new Tuple<string, string>("email", userName),
        //        new Tuple<string, string>("password", userId),
        //        new Tuple<string, string>("revit_login", "true")
        //    };

        //    var content = WebRequest(_baseUrl, _signInResource, "POST", requestParams);

        //    _token = JsonConvert.DeserializeObject<SchemaToken>(content);

        //    return _token.RevitToken != null;
        //}


        public string PriveledgedRequest(string resource)
        {
            var requestHeaders = new List<Tuple<string, string>>()
            {
                new Tuple<string, string>("Authorization"," Token token=" + "hmmph"),
            };

            return WebRequest(_baseUrl, resource, "GET", null, requestHeaders);
        }


        public static string WebRequest(string baseUrl, string resource, string method, IEnumerable<Tuple<string, string>> requestParams, IEnumerable<Tuple<string, string>> requestHeaders = null)
        {
            var client = new RestClient(baseUrl)
            {
                UserAgent =
                    "Mozilla/5.0 (Windows NT 6.3; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/41.0.2272.89 Safari/537.36"
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

        //                System.Net.ServicePointManager.ServerCertificateValidationCallback +=
        //delegate(object sender, System.Security.Cryptography.X509Certificates.X509Certificate certificate,
        //                        System.Security.Cryptography.X509Certificates.X509Chain chain,
        //                        System.Net.Security.SslPolicyErrors sslPolicyErrors)
        //{
        //    return true; // **** Always accept
        //};
    }

    internal class LoginArgs
    {


    }

    public class Links
    {
        public string self { get; set; }
        public string git { get; set; }
        public string html { get; set; }
    }

    public class GitContents
    {

        public GitContents()
        {
            Contents = new List<GitContent>();
        }
        //[JsonArrayAttribute]
        public List<GitContent> Contents { get; set; }
    }

    public class GitContent
    {
        public string name { get; set; }
        public string path { get; set; }
        public string sha { get; set; }
        public int size { get; set; }
        public string url { get; set; }
        public string html_url { get; set; }
        public string git_url { get; set; }
        public string download_url { get; set; }
        public string type { get; set; }
        public string content { get; set; }
        public string encoding { get; set; }
        public Links _links { get; set; }
    }


}
