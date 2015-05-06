using System.Management.Automation;
using ConfluenceShell.BaseCmdlets;
using ConfluenceShell.CmdletTypes;
using ConfluenceShell.ConfluenceService;
using ConfluenceShell.Naming;

namespace ConfluenceShell.Cmdlets
{
    [Cmdlet(VerbsCommon.Add, Noun.Space)]
    public class AddSpace : SpacePsCmdletBase
    {
        [Parameter(Mandatory = true, HelpMessage = "The name of the space", Position = 1)]
        public string Name { get; set; }

        [Parameter(Mandatory = true, HelpMessage = "The description of the space", Position = 2)]
        public string Description { get; set; }

        protected override void ProcessRecord()
        {
            var space = Service.AddSpaceWithDefaultPermissions(new RemoteSpace
            {
                description = Description,
                key = SpaceKey,
                name = Name
            });

            WriteObject(new Space(space));
        }
    }
}