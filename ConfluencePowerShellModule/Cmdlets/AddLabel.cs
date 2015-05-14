using System.Management.Automation;
using ConfluenceShell.BaseCmdlets;
using ConfluenceShell.Naming;

namespace ConfluenceShell.Cmdlets
{
    [Cmdlet(VerbsCommon.Add, Noun.Label)]
    public class AddLabel: ConfluencePSCmdletBase
    {
        [Parameter(Mandatory = true, HelpMessage = "Name of the label to add. For multiple labels, labelName should be in the form of a space-separated or comma-separated string.")]
        public string[] LabelName { get; set; }

        [Parameter(Mandatory = true, HelpMessage = "Id of the object to add the label to.")]
        public long ObjectId { get; set; }

        protected override void ProcessRecord()
        {
            WriteObject(Service.AddLabelByName(string.Join(",", LabelName), ObjectId));
        }
    }
}