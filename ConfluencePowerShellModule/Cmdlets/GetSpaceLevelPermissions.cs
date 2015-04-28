using System.Management.Automation;
using ConfluenceShell.BaseCmdlets;
using ConfluenceShell.Naming;

namespace ConfluenceShell.Cmdlets
{
    [Cmdlet(VerbsCommon.Get, Noun.Space + "LevelPermissions")]
    public class GetSpaceLevelPermissions : ConfluencePSCmdletBase
    {
        protected override void ProcessRecord()
        {           
            WriteObject(Service.GetSpaceLevelPermissions());
        }
    }
}