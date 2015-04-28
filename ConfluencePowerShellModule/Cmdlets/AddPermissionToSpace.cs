using System.Management.Automation;
using ConfluenceShell.BaseCmdlets;
using ConfluenceShell.CmdletTypes;
using ConfluenceShell.Naming;

namespace ConfluenceShell.Cmdlets
{
    [Cmdlet(VerbsCommon.Add, Noun.Permission + "To" + Noun.Space)]
    public class AddPermissionToSpace : SpacePsCmdletBase
    {
        [Parameter(Mandatory = true)]
        public SpaceLevelPermission Permission { get; set; }

        [Parameter(Mandatory = true)]
        public string EntityName { get; set; }

        protected override void ProcessRecord()
        {
            WriteObject(Service.AddPermissionToSpace(Permission.ToString().ToUpper(), EntityName, SpaceKey));
        }
    }
}