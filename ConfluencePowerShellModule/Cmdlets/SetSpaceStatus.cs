using System.Management.Automation;
using ConfluenceShell.BaseCmdlets;
using ConfluenceShell.CmdletTypes;
using ConfluenceShell.Naming;

namespace ConfluenceShell.Cmdlets
{
    [Cmdlet(VerbsCommon.Set, Noun.Space + "Status")]
    public class SetSpaceStatus : SpacePsCmdletBase
    {
        [Parameter(Mandatory = true)]
        public SpaceStatus Status { get; set; }

        protected override void ProcessRecord()
        {
            WriteObject(Service.SetSpaceStatus(SpaceKey, Status.ToString().ToUpper()));
        }
    }
}