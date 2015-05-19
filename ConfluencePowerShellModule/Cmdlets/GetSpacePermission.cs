using System.Linq;
using System.Management.Automation;
using ConfluenceShell.BaseCmdlets;
using ConfluenceShell.CmdletTypes;
using ConfluenceShell.Naming;

namespace ConfluenceShell.Cmdlets
{
    [Cmdlet(VerbsCommon.Get, Noun.Space + "Permission")]
    public class GetSpacePermission : SpacePsCmdletBase
    {
        protected override void ProcessRecord()
        {
            var permissionSets = Service.GetSpacePermissionSets(SpaceKey);

            foreach (var permission in permissionSets.SelectMany(set => set.spacePermissions))
            {
                WriteObject(new SpacePermissionSet(permission));
            }

        }
    }
}