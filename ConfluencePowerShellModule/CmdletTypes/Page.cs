using System;
using ConfluenceShell.ConfluenceService;

namespace ConfluenceShell.CmdletTypes
{
    public class Page
    {
        public string Content { get; set; }
        public string ContentStatus { get; set; }
        public DateTime? Created { get; set; }
        public string Creator { get; set; }
        public bool Current { get; set; }
        public bool HomePage { get; set; }
        public DateTime? Modified { get; set; }
        public string Modifier { get; set; }
        public long ParentId { get; set; }
        public int Version { get; set; }
        public SpaceKey SpaceKey { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }

        public Page(RemotePage page)
        {
            Content = page.content;
            ContentStatus = page.contentStatus;
            Created = page.created;
            Creator = page.creator;
            Current = page.current;
            HomePage = page.homePage;
            Modified = page.modified;
            Modifier = page.modifier;
            ParentId = page.parentId;
            Version = page.version;
            SpaceKey = page.space;
            Title = page.title;
            Url = page.url;
        }
    }
}