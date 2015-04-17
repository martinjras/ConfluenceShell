using System.Management.Automation;

namespace ConfluencePowerShellModule.BaseCmdlets
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
