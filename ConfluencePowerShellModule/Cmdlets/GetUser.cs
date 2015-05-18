using System.Management.Automation;
using ConfluenceShell.BaseCmdlets;
using ConfluenceShell.CmdletTypes;
using ConfluenceShell.Naming;

namespace ConfluenceShell.Cmdlets
{
    [Cmdlet(VerbsCommon.Get, Noun.User, DefaultParameterSetName = AllUsers)]
    public class GetUser : ConfluencePSCmdletBase
    {
        private const string SingleUser = "SingleUser";
        private const string AllUsers = "AllUsers";

        [Parameter(Mandatory = true, HelpMessage = "Username of a user", Position = 0, ParameterSetName = SingleUser)]
        public string Username { get; set; }

        protected override void ProcessRecord()
        {
            if (ParameterSetName == SingleUser)
            {
                WriteObject(new User(Service.GetUser(Username)));
            }
            else
            {
                foreach (var user in Service.GetUsers(true))
                {
                    WriteObject(user);
                }
            }
        }
    }
}