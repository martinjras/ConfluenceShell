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

        [Parameter(HelpMessage = "If the space should use the default permissions configured by the system administrator")]
        public SwitchParameter WithDefaultPermissions { get; set; }

        protected override void ProcessRecord()
        {
            var newSpace = new RemoteSpace
            {
                description = Description,
                key = SpaceKey,
                name = Name
            };

            var space = WithDefaultPermissions ? Service.AddSpaceWithDefaultPermissions(newSpace) 
                : Service.AddSpace(newSpace);

            WriteObject(new Space(space));
        }
    }
}