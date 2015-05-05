using System.Management.Automation;
using ConfluenceShell.BaseCmdlets;
using ConfluenceShell.CmdletTypes;
using ConfluenceShell.Naming;

namespace ConfluenceShell.Cmdlets
{
    [Cmdlet(VerbsCommon.Get, Noun.User)]
    public class GetUser : UserPsCmdletBase
    {
        protected override void ProcessRecord()
        {
            WriteObject(new User(Service.GetUser(Username)));
        }
    }
}