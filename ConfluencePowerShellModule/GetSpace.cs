using System.Management.Automation;
using ConfluencePowerShellModule.BaseCmdlets;
using ConfluencePowerShellModule.Naming;

namespace ConfluencePowerShellModule
{
    [Cmdlet(VerbsCommon.Get, Noun.Space)]
    public class GetSpace : SpacePsCmdletBase
    {
        protected override void ProcessRecord()
        {
            var spaces = Service.GetSpace(SpaceKey);
            WriteObject(spaces);
        }
    }
}