using System.Management.Automation;
using ConfluencePowerShellModule.BaseCmdlets;

namespace ConfluencePowerShellModule
{
    [Cmdlet(VerbsCommon.Get, "Space")]
    public class GetSpace : ConfluencePSCmdlet
    {
        [Parameter(
            Mandatory = true,
            HelpMessage = "The unique key identifing the space key")]
        public string SpaceKey { get; set; }

        protected override void ProcessRecord()
        {
            var spaces = Service.GetSpace(SpaceKey);
            WriteObject(spaces);
        }
    }
}