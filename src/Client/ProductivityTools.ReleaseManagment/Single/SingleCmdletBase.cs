using ProductivityTools.ReleaseManagment.Operations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductivityTools.ReleaseManagment.Single
{
    public abstract class SingleCmdletBase: System.Management.Automation.PSCmdlet
    {
        protected EvOperations EvOperations = new EvOperations();
    }


}
