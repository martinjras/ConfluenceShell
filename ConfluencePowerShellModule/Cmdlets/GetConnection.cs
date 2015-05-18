using System.Management.Automation;
using ConfluencePowerShellModule.Extensions;
using ConfluenceShell.Naming;

namespace ConfluenceShell.Cmdlets
{
    [Cmdlet(VerbsCommon.Get, Noun.Connection)]
    public class GetConnection : PSCmdlet
    {
        [Parameter(Mandatory = true, HelpMessage = "Credentials used to connect to Confluence. Don't use domain pre/postfix. Just the username.")]
        public PSCredential Credentials { get; set; }

        [Parameter(Mandatory = true, HelpMessage = "The BaseUrl of the Confluence instance you are connecting to. e.g. https://wiki")]
        public string BaseUrl { get; set; }

        protected override void ProcessRecord()
        {
            var service = new ConfluenceServiceWrapper(ConfigurationProvider.GetConfluenceServiceUrl(BaseUrl));

            string authToken = service.Login(Credentials.UserName, Credentials.Password.ConvertToUnsecureString());
            
            WriteObject(new ConfluenceConnection(BaseUrl, authToken));
        }
    }
}