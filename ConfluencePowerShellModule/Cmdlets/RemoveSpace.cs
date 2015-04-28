﻿using System.Management.Automation;
using ConfluenceShell.BaseCmdlets;
using ConfluenceShell.Naming;

namespace ConfluenceShell.Cmdlets
{
    [Cmdlet(VerbsCommon.Remove, Noun.Space)]
    public class RemoveSpace : SpacePsCmdletBase
    {
        protected override void ProcessRecord()
        {
            WriteObject(Service.RemoveSpace(SpaceKey));
        }
    }
}