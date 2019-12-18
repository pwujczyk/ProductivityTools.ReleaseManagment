using System;
using System.Collections.Generic;
using System.Text;

namespace ProductivityTools.ReleaseManagment.Contract
{
    public class Release : Schedule
    {

        public DateTime Freeze { get; set; }

    }
}
