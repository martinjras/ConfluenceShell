using System.Linq;
using System.Management.Automation;
using ConfluenceShell.BaseCmdlets;
using ConfluenceShell.CmdletTypes;

namespace ConfluenceShell.Cmdlets
{
    [Cmdlet(VerbsCommon.Get, "Spaces")]
    public class GetSpaces : ConfluencePSCmdletBase
    {
        protected override void ProcessRecord()
        {
            var spaces = Service.GetSpaces()
                            .Select(s => new Space(s))
                            .ToArray();

            WriteObject(spaces);
        }
    }
}
