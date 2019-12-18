using System;
using System.Collections.Generic;

namespace ProductivityTools.ReleaseManagment.Contract
{
    public class ReleaseInfo
    {
        public IList<Release> Releases { get; set; }

        public List<Sprint> Sprints { get; set; }
    }
}

//Previous Release: Release 10.4
//Previous Release Deploy

//Current Release: Release 10.5
//Current release freeze: 
//Current release Deploy

//Next Relase 10.6
//Next release deploy


//Curent Sprint: 
//Days till end of sprint



