using System;
using System.IO;
using System.Xml;
using System.Collections.Generic;
using GitDownloader;
using Newtonsoft.Json;
using UavObjectGenerator;

namespace UavGen
{
    class MainClass
    {
        private static string url = @"https://api.github.com/repos/taulabs/taulabs/contents/shared/uavobjectdefinition";

        public static int Main(string[] args)
        {
            try
            {

                
                var test = GitWebClient.WebRequest(url, "", "GET", null, null);
                var response = JsonConvert.DeserializeObject<GitContent[]>(test);

                var contents = new GitContents();

                foreach (var gitContent in response)
                {
                    var contentResponse =  GitWebClient.WebRequest(gitContent.download_url, "", "GET", null, null);

                    XmlDocument xm = new XmlDocument();
                    xm.LoadXml(contentResponse);
                    //var contentObject = JsonConvert.DeserializeObject<GitContent>(contentResponse);


                    //if (contentObject != null) contents.Contents.Add(contentObject);
                }

                

                Configuration c = new Configuration(args);
                c.CheckValid();

                foreach (string s in c.Files)
                {
                    try
                    {
                        string fileName = Path.GetFileNameWithoutExtension(s);
                        string outputFileName = Path.Combine(c.OutputDir, fileName + ".cs");
                        new XmlParser(s).Generate(outputFileName);
                    }
                    catch (Exception ex)
                    {
                        Console.Error.WriteLine("Error in [{0}]: {1} ", s, ex.Message);
                    }
                }

                SummaryGenerator.Write(c.OutputDir);

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
