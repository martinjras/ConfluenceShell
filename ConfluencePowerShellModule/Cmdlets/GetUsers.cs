using System.Management.Automation;
using ConfluenceShell.BaseCmdlets;
using ConfluenceShell.Naming;

namespace ConfluenceShell.Cmdlets
{
    [Cmdlet(VerbsCommon.Get, Noun.Users)]
    public class GetUsers : ConfluencePSCmdletBase
    {
        protected override void ProcessRecord()
        {
            WriteObject(Service.GetUsers(true));
        }
    }
}