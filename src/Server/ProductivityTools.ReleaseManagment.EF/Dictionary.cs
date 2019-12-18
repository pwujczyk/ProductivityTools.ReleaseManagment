using System;
using System.Collections.Generic;

namespace ProductivityTools.ReleaseManagment.EF
{
    public partial class Dictionary
    {
        public Dictionary()
        {
            DictValue = new HashSet<DictValue>();
        }

        public int DictionaryId { get; set; }
        public string Name { get; set; }
        public DateTime CreatedDate { get; set; }

        public virtual ICollection<DictValue> DictValue { get; set; }
    }
}
