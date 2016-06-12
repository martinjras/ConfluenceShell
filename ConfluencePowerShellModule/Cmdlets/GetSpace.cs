using System.Linq;
using System.Management.Automation;
using ConfluenceShell.BaseCmdlets;
using ConfluenceShell.CmdletTypes;
using ConfluenceShell.Naming;

namespace ConfluenceShell.Cmdlets
{
    [Cmdlet(VerbsCommon.Get, Noun.Space, DefaultParameterSetName = AllSpaces)]
    public class GetSpace : SpacePsCmdletBase
    {
        private const string SingleSpace = "SingleSpace";
        private const string AllSpaces = "AllSpaces";

        [Parameter(Mandatory = true, HelpMessage = "The unique key identifing the space",
            Position = 0, ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, ParameterSetName = SingleSpace)]
        public new SpaceKey SpaceKey { get; set; }

        protected override void ProcessRecord()
        {
            if (ParameterSetName == SingleSpace)
            {
                try
                {
                    var space = new Space(Service.GetSpace(SpaceKey));
                    WriteObject(space);
                }
                catch (System.Exception ex)
                {
                    WriteError(new ErrorRecord(ex, "GetSpaceError", ErrorCategory.ResourceUnavailable, SpaceKey));
                }
               
            }
            else
            {
                foreach (var space in Service.GetSpaces().Select(s => new Space(s)))
                {
                    WriteObject(space);
                }
            }
           
        }
    }
}