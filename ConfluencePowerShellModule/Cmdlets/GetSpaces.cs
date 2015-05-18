using System.Linq;
using System.Management.Automation;
using ConfluenceShell.BaseCmdlets;
using ConfluenceShell.CmdletTypes;
using ConfluenceShell.Naming;

namespace ConfluenceShell.Cmdlets
{
    [Cmdlet(VerbsCommon.Get, Noun.Spaces)]
    public class GetSpaces : ConfluencePSCmdletBase
    {
        protected override void ProcessRecord()
        {
            foreach (var space in Service.GetSpaces().Select(s => new Space(s)))
            {
                WriteObject(space);
            }
        }
    }
}
