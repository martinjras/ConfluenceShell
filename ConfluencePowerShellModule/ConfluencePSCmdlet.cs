using System.Management.Automation;

namespace ConfluencePowerShellModule
{
    // ReSharper disable once InconsistentNaming
    public class ConfluencePSCmdlet : PSCmdlet
    {
        [Parameter(
            Mandatory = true,
            HelpMessage = "Provide the base url for the Confluence instance. e.g. http://wiki")]
        public string SiteUrl { get; set; }

        [Parameter(
            Mandatory = true,
            HelpMessage = "Provide the AuthToken issued by calling Get-AuthToken")]
        public string AuthToken { get; set; }


        protected ConfluenceServiceWrapper Service;

        protected override void BeginProcessing()
        {
            Service = new ConfluenceServiceWrapper();
        }
    }
}
