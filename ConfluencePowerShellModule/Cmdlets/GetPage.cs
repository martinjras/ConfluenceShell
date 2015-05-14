using System.Management.Automation;
using ConfluenceShell.BaseCmdlets;
using ConfluenceShell.CmdletTypes;
using ConfluenceShell.Naming;

namespace ConfluenceShell.Cmdlets
{
    [Cmdlet(VerbsCommon.Get, Noun.Page)]
    public class GetPage : ConfluencePSCmdletBase
    {
        [Parameter(Mandatory = true, HelpMessage = "Id of the page to get", Position = 0)]
        public long PageId { get; set; }

        protected override void ProcessRecord()
        {
            var remotePage = Service.GetPage(PageId);

            WriteObject(new Page(remotePage));
        }
    }
}