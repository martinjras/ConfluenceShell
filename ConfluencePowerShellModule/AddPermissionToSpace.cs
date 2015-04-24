using System.Management.Automation;
using ConfluencePowerShellModule.BaseCmdlets;
using ConfluencePowerShellModule.Naming;

namespace ConfluencePowerShellModule
{
    [Cmdlet(VerbsCommon.Add, Noun.Permission + "To" + Noun.Space)]
    public class AddPermissionToSpace : SpacePsCmdletBase
    {
        [Parameter(Mandatory = true)]
        public string Permission { get; set; }

        [Parameter(Mandatory = true)]
        public string EntityName { get; set; }

        protected override void ProcessRecord()
        {
            WriteObject(Service.AddPermissionToSpace(Permission, EntityName, SpaceKey));
        }
    }
}