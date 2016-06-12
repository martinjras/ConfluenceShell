using System.Management.Automation;
using ConfluenceShell.BaseCmdlets;
using ConfluenceShell.Naming;

namespace ConfluenceShell.Cmdlets
{
    [Cmdlet(VerbsCommon.Remove, Noun.Space, SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    public class RemoveSpace : SpacePsCmdletBase
    {
        [Parameter()]
        public SwitchParameter Force { get; set; }

        protected override void ProcessRecord()
        {
            if (ShouldProcess(SpaceKey, VerbsCommon.Remove))
            {
                if (Force || ShouldContinue(string.Format("Are you sure you wish to delete the space '{0}'", SpaceKey), "Deleting a space can't be undone!"))
                {
                    try
                    {
                        Service.RemoveSpace(SpaceKey);
                        WriteVerbose(SpaceKey + " deleted");
                    }
                    catch (System.Exception ex)
                    {
                        WriteError(new ErrorRecord(ex, "RemoveSpaceError", ErrorCategory.ResourceUnavailable, SpaceKey));
                    }
                }
            }
        }
    }
}