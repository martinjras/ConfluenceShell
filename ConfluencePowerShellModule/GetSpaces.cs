using System.Management.Automation;
using ConfluencePowerShellModule.BaseCmdlets;

namespace ConfluencePowerShellModule
{
    [Cmdlet(VerbsCommon.Get, "Spaces")]
    public class GetSpaces : ConfluencePSCmdlet
    {
        protected override void ProcessRecord()
        {
            var spaces = Service.GetSpaces();
            WriteObject(spaces);
        }
    }
}
