using System.Collections.Generic;

namespace GitDownloader
{
    public class GitContents
    {

        public GitContents()
        {
            Contents = new List<GitContent>();
        }

        public List<GitContent> Contents { get; set; }
    }
}