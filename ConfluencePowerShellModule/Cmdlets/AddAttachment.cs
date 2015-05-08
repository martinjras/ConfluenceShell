using System.IO;
using System.Management.Automation;
using ConfluenceShell.BaseCmdlets;
using ConfluenceShell.CmdletTypes;
using ConfluenceShell.ConfluenceService;
using ConfluenceShell.Naming;
using ConfluenceShell.Validation;

namespace ConfluenceShell.Cmdlets
{
    [Cmdlet(VerbsCommon.Add, Noun.Attachment)]
    public class AddAttachment : ConfluencePSCmdletBase
    {
        [Parameter(Mandatory = true, HelpMessage = "A path to the file that should be uploaded")]
        [ValidateFileExists]
        public string FilePath { get; set; }

        [Parameter(Mandatory = true, HelpMessage = "The id of the page to attach the file")]
        public long PageId { get; set; }

        [Parameter(Mandatory = true, HelpMessage = "Content-type / mime-type")]
        public string ContentType { get; set; }

        [Parameter(HelpMessage = "A comment to associate with the attachment")]
        public string Comment { get; set; }

        [Parameter(HelpMessage = "The name of the file in Confluence, including the file extension. " +
                                 "Defaults to the filename of FilePath")]
        public string FileName { get; set; }

        protected override void ProcessRecord()
        {
            // get filename from FilePath if not already set
            FileName = !string.IsNullOrEmpty(FileName) ? FileName : new FileInfo(FilePath).Name;

            var attachment = new RemoteAttachment
            {
                comment = Comment,
                contentType = ContentType,
                fileName = FileName
            };

            var resultAtt = Service.AddAttachment(attachment, PageId, File.ReadAllBytes(FilePath));

            WriteObject(new Attachment(resultAtt));
        }
    }
}