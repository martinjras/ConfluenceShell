using System.Management.Automation;

namespace ConfluencePowerShellModule
{
    [Cmdlet(VerbsCommon.Get, "Spaces")]
    public class GetSpaces : ConfluencePSCmdlet
    {
        protected override void ProcessRecord()
        {
            var spaces = Service.GetSpaces(AuthToken);
            WriteObject(spaces);
        }
    }

    [Cmdlet(VerbsCommon.Get, "Space")]
    public class GetSpace : ConfluencePSCmdlet
    {
        [Parameter(
            Mandatory = true,
            HelpMessage = "The unique key identifing the space key")]
        public string SpaceKey { get; set; }

        protected override void ProcessRecord()
        {
            var spaces = Service.GetSpace(AuthToken, SpaceKey);
            WriteObject(spaces);
        }
    }
}
