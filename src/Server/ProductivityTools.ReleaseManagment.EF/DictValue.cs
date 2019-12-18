using System;
using System.Collections.Generic;

namespace ProductivityTools.ReleaseManagment.EF
{
    public partial class DictValue
    {
        public int DictValueId { get; set; }
        public int DictionaryId { get; set; }
        public string Key { get; set; }
        public string ValuePl { get; set; }
        public string ValueEn { get; set; }
        public int Order { get; set; }
        public DateTime CreatedDate { get; set; }

        public virtual Dictionary Dictionary { get; set; }
    }
}
