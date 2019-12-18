using ProductivityTools.ReleaseManagment.Operations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductivityTools.ReleaseManagment.Cmdlets.GetSprints.Commands
{
    public class GetCurrentSprint : ProductivityTools.PSCmdlet.PSCommandPT<GetSprintsCmdlet>
    {
        protected override bool Condition => true;

        public GetCurrentSprint(GetSprintsCmdlet cmdlet) : base(cmdlet) { }

        protected override void Invoke()
        {
            EvOperations EvOperations = new EvOperations();
            var releaseInfo = EvOperations.GetSprints();
            this.Cmdlet.WriteObject(releaseInfo);
        }
    }
}
