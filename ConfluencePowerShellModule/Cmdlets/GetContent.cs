using System.Management.Automation;
using ConfluenceShell.BaseCmdlets;
using ConfluenceShell.CmdletTypes;
using ConfluenceShell.Naming;

namespace ConfluenceShell.Cmdlets
{
    [Cmdlet(VerbsCommon.Get, Noun.Content)]
    public class GetContent : ConfluencePSCmdletBase
    {
        [Parameter(Mandatory = true, HelpMessage = "Id of the label to search content with")]
        public long LabelId { get; set; }

        protected override void ProcessRecord()
        {
            var results = Service.GetLabelContentById(LabelId);

            foreach (var result in results)
            {
                WriteObject(new SearchResult(result));
            }
        }
    }
}