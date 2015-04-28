using System.Linq;
using System.Management.Automation;
using ConfluenceShell.BaseCmdlets;
using ConfluenceShell.CmdletTypes;
using ConfluenceShell.Naming;

namespace ConfluenceShell.Cmdlets
{
    [Cmdlet(VerbsCommon.Add, Noun.Permissions + "To" + Noun.Space)]
    public class AddPermissionsToSpace : SpacePsCmdletBase
    {
        [Parameter(Mandatory = true)]
        public SpaceLevelPermission[] Permissions { get; set; }

        [Parameter(Mandatory = true)]
        public string EntityName { get; set; }

        protected override void ProcessRecord()
        {
            var stringPermissions = Permissions.Select(p => p.ToString().ToUpper())
                                            .ToArray();

            WriteObject(Service.AddPermissionsToSpace(stringPermissions, EntityName, SpaceKey));
        }
    }
}