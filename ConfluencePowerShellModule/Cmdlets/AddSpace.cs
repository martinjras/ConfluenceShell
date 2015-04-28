using System.Management.Automation;
using ConfluenceShell.BaseCmdlets;
using ConfluenceShell.ConfluenceService;
using ConfluenceShell.Naming;

namespace ConfluenceShell.Cmdlets
{
    [Cmdlet(VerbsCommon.Add, Noun.Space)]
    public class AddSpace : SpacePsCmdletBase
    {
        protected override void ProcessRecord()
        {
            var spaces = Service.AddSpaceWithDefaultPermissions(new RemoteSpace
            {
                description = "Description",
                key = SpaceKey,
                name = "SomeName",
                type = "global"
            });
            WriteObject(spaces);
        }
    }
}