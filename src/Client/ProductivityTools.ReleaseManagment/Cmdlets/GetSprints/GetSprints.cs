using ProductivityTools.ReleaseManagment.Cmdlets.GetSprints.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Text;
using System.Threading.Tasks;

namespace ProductivityTools.ReleaseManagment.Cmdlets
{
    [Cmdlet(VerbsCommon.Get, "Sprints")]
    public class GetSprintsCmdlet : CmdletBase
    {
        public GetSprintsCmdlet()
        {
            this.AddCommand(new GetAllSprints(this));
            this.AddCommand(new GetCurrentSprint(this));
        }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            this.ProcessCommands();
        }
    }
}
