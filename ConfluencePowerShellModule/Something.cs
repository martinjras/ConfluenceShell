using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Management.Automation;

namespace ConfluencePowerShellModule
{
    [Cmdlet(VerbsCommon.Get, "Spaces")]
    public class GetSpaces : PSCmdlet
    {
        [Parameter(
            Mandatory = true,
            Position = 0,
            HelpMessage = "Provide the AuthToken issued by calling Get-AuthToken")]
        public string AuthToken { get; set; }

        private ConfluenceServiceWrapper _wrapper;

        protected override void BeginProcessing()
        {
            _wrapper = new ConfluenceServiceWrapper();
        }

        protected override void ProcessRecord()
        {
            _wrapper.GetSpaces(AuthToken);
        }
    }
}
