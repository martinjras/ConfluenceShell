using System.Management.Automation;
using ConfluencePowerShellModule.BaseCmdlets;
using ConfluencePowerShellModule.Naming;

namespace ConfluencePowerShellModule
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