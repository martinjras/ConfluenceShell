using System.Management.Automation;
using ConfluenceShell.BaseCmdlets;
using ConfluenceShell.Naming;

namespace ConfluenceShell.Cmdlets
{
    [Cmdlet(VerbsCommon.Get, Noun.Group)]
    public class GetGroup : ConfluencePSCmdletBase
    {
        protected override void ProcessRecord()
        {
            foreach (var group in Service.GetGroups())
            {
                WriteObject(group);
            }
        }
    }
}