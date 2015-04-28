using System.Management.Automation;
using ConfluenceShell.BaseCmdlets;
using ConfluenceShell.Naming;

namespace ConfluenceShell.Cmdlets
{
    [Cmdlet(VerbsCommon.Get, Noun.Space + "Status")]
    public class GetSpaceStatus : SpacePsCmdletBase
    {
        protected override void ProcessRecord()
        {
            WriteObject(Service.GetSpaceStatus(SpaceKey));
        }
    }
}