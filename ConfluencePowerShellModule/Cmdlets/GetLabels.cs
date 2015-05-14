using System.Management.Automation;
using ConfluenceShell.BaseCmdlets;
using ConfluenceShell.CmdletTypes;
using ConfluenceShell.Naming;

namespace ConfluenceShell.Cmdlets
{
    [Cmdlet(VerbsCommon.Get, Noun.Labels)]
    public class GetLabels : ConfluencePSCmdletBase
    {
        [Parameter(Mandatory = true, HelpMessage = "Id of the object to get labels from", Position = 0)]
        public long ObjectId { get; set; }

        protected override void ProcessRecord()
        {
            foreach (var label in Service.GetLabels(ObjectId))
            {
                WriteObject(new Label(label));
            }
        }
    }
}