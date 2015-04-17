using System.Management.Automation;
using ConfluencePowerShellModule.BaseCmdlets;
using ConfluencePowerShellModule.ConfluenceService;
using ConfluencePowerShellModule.Naming;

namespace ConfluencePowerShellModule
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