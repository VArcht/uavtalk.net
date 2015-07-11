using GitDownloader;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Xml.Linq;
using UavObjectGenerator;

namespace UavGen
{
    class MainClass
    {
        private const string Url = "https://api.github.com/repos/taulabs/taulabs/contents/shared/uavobjectdefinition";
        private const string OutputDir = @"D:\Uavtalk.net\master\UavTalk\UavObjects\";

        public static int Main(string[] args)
        {
            try
            {
                var test = GitWebClient.WebRequest(Url, "", "GET", null);
                var response = JsonConvert.DeserializeObject<GitContent[]>(test);

                foreach (var gitContent in response)
                {
                    var contentResponse =  GitWebClient.WebRequest(gitContent.download_url, "", "GET", null);

                    XDocument xm = XDocument.Parse(contentResponse);

                    var fileName = Path.GetFileNameWithoutExtension(gitContent.path);

                    new XmlParser("").Generate(xm, string.Format(@"{0}{1}.cs", OutputDir, fileName));
                }

                SummaryGenerator.Write(OutputDir);

                return 0;
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine(ex.Message);
                return 1;
            }
        }
    }
}
