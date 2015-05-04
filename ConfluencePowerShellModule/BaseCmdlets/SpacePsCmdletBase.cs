using System.Management.Automation;
using ConfluenceShell.CmdletTypes;

namespace ConfluenceShell.BaseCmdlets
{
    public class SpacePsCmdletBase : ConfluencePSCmdletBase
    {
        [Parameter(Mandatory = true, HelpMessage = "The unique key identifing the space",
            Position = 0, ValueFromPipeline = true, ValueFromPipelineByPropertyName = true)]
        public SpaceKey SpaceKey { get; set; }
    }
}