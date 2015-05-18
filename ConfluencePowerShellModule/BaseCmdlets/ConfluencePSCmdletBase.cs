using System;
using System.Management.Automation;
using ConfluenceShell.Session;

namespace ConfluenceShell.BaseCmdlets
{
    // ReSharper disable once InconsistentNaming
    public class ConfluencePSCmdletBase : PSCmdlet
    {
        [Parameter(HelpMessage = "Get a ConfluenceConnection by calling Get-ConfluenceConnection")]
        public ConfluenceConnection Connection { get; set; }

        protected ConfluenceServiceWrapper Service;

        protected override void BeginProcessing()
        {
            ValidateParameters();

            Service = new ConfluenceServiceWrapper(ConfigurationProvider.GetConfluenceServiceUrl(Connection.BaseUrl),
                Connection.AuthToken);
        }

        private void ValidateParameters()
        {
            // if no connection was supplied
            if (Connection == null)
            {
                // check if already set in session state
                Connection = SessionState.PSVariable.GetValue(VariableNames.ConfluenceConnection) as ConfluenceConnection;

                // if it's still not there, throw argument exception
                if (Connection == null)
                {
                    ThrowParameterError("Connection");
                }
            }

        }

        protected void ThrowParameterError(string parameterName)
        {
            ThrowTerminatingError(
                new ErrorRecord(new ArgumentException(string.Format("Must specify '{0}'", parameterName)),
                    Guid.NewGuid().ToString(),
                    ErrorCategory.InvalidArgument,
                    null));
        }
    }
}
