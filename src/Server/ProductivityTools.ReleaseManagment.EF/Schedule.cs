using System;
using System.Collections.Generic;

namespace ProductivityTools.ReleaseManagment.EF
{
    public partial class Schedule
    {
        public Schedule()
        {
            InverseParentSchedule = new HashSet<Schedule>();
        }

        public int ScheduleId { get; set; }
        public string Name { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public int? ParentScheduleId { get; set; }
        public int ScheduleTypeDvid { get; set; }
        public DateTime CreatedDate { get; set; }

        public virtual Schedule ParentSchedule { get; set; }
        public virtual ICollection<Schedule> InverseParentSchedule { get; set; }
    }
}
