using ConfluenceShell.ConfluenceService;

namespace ConfluenceShell.CmdletTypes
{
    public class SearchResult
    {
        public long Id { get; private set; }
        public string Type { get; private set; }
        public string Title { get; private set; }
        public string Excerpt { get; private set; }
        public string Url { get; private set; }

        public SearchResult(RemoteSearchResult result)
        {
            Id = result.id;
            Excerpt = result.excerpt;
            Title = result.title;
            Type = result.type;
            Url = result.url;
        }
    }
}
