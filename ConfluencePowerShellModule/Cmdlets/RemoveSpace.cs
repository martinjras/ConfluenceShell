using System.Management.Automation;
using ConfluencePowerShellModule.Naming;
using ConfluenceShell.BaseCmdlets;

namespace ConfluenceShell.Cmdlets
{
    [Cmdlet(VerbsCommon.Remove, Noun.Space)]
    public class RemoveSpace : SpacePsCmdletBase
    {
        protected override void ProcessRecord()
        {
            WriteObject(Service.RemoveSpace(SpaceKey));
        }
    }
}