using System.Management.Automation;
using ConfluencePowerShellModule.Naming;
using ConfluenceShell.BaseCmdlets;
using ConfluenceShell.CmdletTypes;

namespace ConfluenceShell.Cmdlets
{
    [Cmdlet(VerbsCommon.Get, Noun.Space)]
    public class GetSpace : SpacePsCmdletBase
    {
        protected override void ProcessRecord()
        {
            var space = new Space(Service.GetSpace(SpaceKey));
            WriteObject(space);
        }
    }
}