using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Text;
using System.Threading.Tasks;

namespace ProductivityTools.ReleaseManagment.Single
{
    [Cmdlet(VerbsCommon.Get, "ReleaseInfo")]
    public class GetReleaseInfo: SingleCmdletBase
    {
        protected override void ProcessRecord()
        {
            var releaseInfo=EvOperations.GetReleaseInfo();
            WriteObject(releaseInfo);
            base.ProcessRecord();
        }
    }
}
