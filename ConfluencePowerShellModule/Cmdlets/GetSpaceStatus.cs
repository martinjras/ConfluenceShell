using System.Management.Automation;
using ConfluenceShell.BaseCmdlets;
using ConfluenceShell.Naming;
using System;
using ConfluenceShell.CmdletTypes;

namespace ConfluenceShell.Cmdlets
{
    [Cmdlet(VerbsCommon.Get, Noun.Space + "Status")]
    public class GetSpaceStatus : SpacePsCmdletBase
    {
        protected override void ProcessRecord()
        {
            try
            {
                var status = Service.GetSpaceStatus(SpaceKey);

                WriteObject(Enum.Parse(typeof(SpaceStatus), status, true));
            }
            catch (Exception ex)
            {
                WriteError(new ErrorRecord(ex, "GetSpaceStatusError", ErrorCategory.ResourceUnavailable, SpaceKey));
            }
        }
    }
}