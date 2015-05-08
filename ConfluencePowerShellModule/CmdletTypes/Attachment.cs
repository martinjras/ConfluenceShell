using System;
using ConfluenceShell.ConfluenceService;

namespace ConfluenceShell.CmdletTypes
{
    public class Attachment
    {
        public string Comment { get; set; }
        public string ContentType { get; set; }
        public DateTime? DateTime { get; set; }
        public string Creator { get; set; }
        public string FileName { get; set; }
        public long FileSize { get; set; }
        public long Id { get; set; }
        public long PageId { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }

        public Attachment(RemoteAttachment attachment)
        {
            Comment = attachment.comment;
            ContentType = attachment.contentType;
            DateTime = attachment.created;
            Creator = attachment.creator;
            FileName = attachment.fileName;
            FileSize = attachment.fileSize;
            Id = attachment.id;
            PageId = attachment.pageId;
            Title = attachment.title;
            Url = attachment.url;
        }
    }
}
