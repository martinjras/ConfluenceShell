using System.Management.Automation;

namespace ConfluencePowerShellModule.BaseCmdlets
{
    public class SpacePsCmdletBase : ConfluencePSCmdletBase
    {
        [Parameter(Mandatory = true, HelpMessage = "The unique key identifing the space")]
        public string SpaceKey { get; set; }
    }
}