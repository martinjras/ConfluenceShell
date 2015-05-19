using System.Management.Automation;
using ConfluencePowerShellModule.Extensions;
using ConfluenceShell.Naming;
using ConfluenceShell.Session;

namespace ConfluenceShell.Cmdlets
{
    [Cmdlet(VerbsCommon.Get, "Confluence" + Noun.Connection)]
    public class GetConfluenceConnection : PSCmdlet
    {
        [Parameter(Mandatory = true, HelpMessage = "Credentials used to connect to Confluence. Don't use domain pre/postfix. Just the username.")]
        public PSCredential Credentials { get; set; }

        [Parameter(Mandatory = true, HelpMessage = "The BaseUrl of the Confluence instance you are connecting to. e.g. https://wiki")]
        public string BaseUrl { get; set; }

        protected override void ProcessRecord()
        {
            var service = new ConfluenceServiceWrapper(ConfigurationProvider.GetConfluenceServiceUrl(BaseUrl));

            string authToken = service.Login(Credentials.UserName, Credentials.Password.ConvertToUnsecureString());

            var connection = new ConfluenceConnection(BaseUrl, authToken);

            StoreConnectionInSession(connection);

            WriteObject(connection);
        }

        private void StoreConnectionInSession(ConfluenceConnection connection)
        {
            SessionState.PSVariable.Set(VariableNames.ConfluenceConnection, connection);
            WriteVerbose(string.Format("Connection was successfully stored in Sesssion as '{0}'.", VariableNames.ConfluenceConnection));
        }
    }
}