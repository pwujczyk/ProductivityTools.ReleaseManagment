using System;
using System.Collections.Generic;

namespace ProductivityTools.ReleaseManagment.EF
{
    public partial class DbUp
    {
        public int Id { get; set; }
        public string ScriptName { get; set; }
        public DateTime Applied { get; set; }
    }
}
