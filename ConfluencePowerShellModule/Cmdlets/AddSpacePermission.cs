using System.Linq;
using System.Management.Automation;
using ConfluenceShell.BaseCmdlets;
using ConfluenceShell.CmdletTypes;
using ConfluenceShell.Naming;

namespace ConfluenceShell.Cmdlets
{
    [Cmdlet(VerbsCommon.Add, Noun.Space + "Permission", DefaultParameterSetName = UserOrGroup)]
    public class AddSpacePermission : SpacePsCmdletBase
    {
        private const string UserOrGroup = "UserOrGroup";
        private const string Anonymous = "Anonymous";

        [Parameter(HelpMessage = "If the permissions should be assigned to the Anonymous group (users not logged in)", ParameterSetName = Anonymous)]
        public SwitchParameter ToAnonymous { get; set; }

        [Parameter(Mandatory = true)]
        public SpaceLevelPermission[] Permissions { get; set; }

        [Parameter(Mandatory = true, HelpMessage = "The user or group to assign permissions to", ParameterSetName = UserOrGroup)]
        public string EntityName { get; set; }

        protected override void ProcessRecord()
        {
            var stringPermissions = Permissions.Select(p => p.ToString().ToUpper())
                                            .ToArray();

            var result = ToAnonymous
                ? Service.AddAnonymousPermissionsToSpace(stringPermissions, SpaceKey)
                : Service.AddPermissionsToSpace(stringPermissions, EntityName, SpaceKey);

            if (result) { 
                WriteVerbose("Permissions successfully added");
            }
            else {
                WriteWarning("The operation did not return 'true'. Something could be wrong.");
            }
        }
    }
}