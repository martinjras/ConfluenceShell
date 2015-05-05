using System.Management.Automation;

namespace ConfluenceShell.BaseCmdlets
{
    public class UserPsCmdletBase : ConfluencePSCmdletBase
    {
        [Parameter(Mandatory = true, HelpMessage = "Username of a user",
            Position = 0)]
        public string Username { get; set; }
    }
}