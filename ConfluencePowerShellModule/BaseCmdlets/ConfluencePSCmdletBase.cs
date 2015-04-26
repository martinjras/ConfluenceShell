using System.Management.Automation;
using ConfluencePowerShellModule;

namespace ConfluenceShell.BaseCmdlets
{
    // ReSharper disable once InconsistentNaming
    public class ConfluencePSCmdletBase : PSCmdlet
    {
        [Parameter(Mandatory = true, HelpMessage = "Get a ConfluenceConnection by calling Get-ConfluenceConnection")]
        public ConfluenceConnection Connection { get; set; }

        protected ConfluenceServiceWrapper Service;

        protected override void BeginProcessing()
        {
            Service = new ConfluenceServiceWrapper(ConfigurationProvider.GetConfluenceServiceUrl(Connection.BaseUrl),
                Connection.AuthToken);
        }
    }
}
