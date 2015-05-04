using System.Management.Automation;
using ConfluenceShell.BaseCmdlets;
using ConfluenceShell.CmdletTypes;
using ConfluenceShell.Naming;

namespace ConfluenceShell.Cmdlets
{
    [Cmdlet(VerbsCommon.Get, Noun.User)]
    public class GetUser : ConfluencePSCmdletBase
    {
        [Parameter(Mandatory = true, HelpMessage = "Username of the user to get", Position = 0)]
        public string UserName { get; set; }

        protected override void ProcessRecord()
        {
            WriteObject(new User(Service.GetUser(UserName)));
        }
    }
}