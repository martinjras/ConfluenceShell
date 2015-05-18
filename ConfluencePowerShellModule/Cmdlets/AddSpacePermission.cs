using System.Linq;
using System.Management.Automation;
using ConfluenceShell.BaseCmdlets;
using ConfluenceShell.CmdletTypes;
using ConfluenceShell.Naming;

namespace ConfluenceShell.Cmdlets
{
    [Cmdlet(VerbsCommon.Add, Noun.Space + "Permission")]
    public class AddSpacePermission : SpacePsCmdletBase
    {
        [Parameter(Mandatory = true)]
        public SpaceLevelPermission[] Permissions { get; set; }

        [Parameter(Mandatory = true, HelpMessage = "The user or group to assign permissions to")]
        public string EntityName { get; set; }

        protected override void ProcessRecord()
        {
            var stringPermissions = Permissions.Select(p => p.ToString().ToUpper())
                                            .ToArray();

            WriteObject(Service.AddPermissionsToSpace(stringPermissions, EntityName, SpaceKey));
        }
    }
}