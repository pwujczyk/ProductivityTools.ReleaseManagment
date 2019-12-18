using AutoMapper;
using ProductivityTools.DateTimeTools;
using ProductivityTools.ReleaseManagment.App.InternalContract;
using ProductivityTools.ReleaseManagment.Contract;
using ProductivityTools.ReleaseManagment.EF;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProductivityTools.ReleaseManagment.App
{
    public class ReleasesOperations : IReleases
    {

        private readonly EcoVadisTMContext EcoVadisTMContext;
        private readonly IDictionary Dictionary;
        private readonly IDateTimePT Date;


        public ReleasesOperations(EcoVadisTMContext ecoVadisTMContext, IDictionary dictionary, IDateTimePT date)
        {
            EcoVadisTMContext = ecoVadisTMContext;
            Dictionary = dictionary;
            Date = date;
            AutoMapper.Setup();
        }

        public DateTime GetDate()
        {
            return DateTime.Now;
        }

        public IList<Contract.Schedule> GetSprints()
        {
            var x = GetSchedules(DV.Sprint);
            return x;
        }

        public IList<Contract.Schedule> GetBugFixes()
        {
            var x = GetSchedules(DV.BugFix);
            return x;
        }

        public IList<Contract.Schedule> GetReleases()
        {
            var x = GetSchedules(DV.Release);
            return x;
        }

        private IList<Contract.Schedule> GetSchedules(string scheduletype)
        {
            List<EF.Schedule> x = EcoVadisTMContext.Schedule.Where(i => i.ScheduleTypeDvid == Dictionary.GetDVId(D.ScheduleType, scheduletype)).ToList();
            var result = Mapper.Map<List<Contract.Schedule>>(x);
            return result;
        }

        private List<Contract.Schedule> GetCurrentSchedules(string scheduleType)
        {
            List<EF.Schedule> x = EcoVadisTMContext.Schedule.Where(i =>
                            i.ScheduleTypeDvid == Dictionary.GetDVId(D.ScheduleType, scheduleType)
                            && i.Start < Date.Now && i.End > Date.Now).ToList();
            var result = Mapper.Map<List<Contract.Schedule>>(x);
            return result;
        }

        private Contract.Schedule GetCurrentSchedule(string scheduleType)
        {
            EF.Schedule x = EcoVadisTMContext.Schedule.Where(i =>
                            i.ScheduleTypeDvid == Dictionary.GetDVId(D.ScheduleType, scheduleType)
                            && i.Start < Date.Now && i.End > Date.Now).SingleOrDefault();
            var result = Mapper.Map<Contract.Schedule>(x);
            return result;
        }

        public Contract.Schedule GetCurrentSprint()
        {
            var x = GetCurrentSchedule(DV.Sprint);
            return x;
        }

        public Contract.Schedule GetCurrentBugFix()
        {
            var x = GetCurrentSchedule(DV.BugFix);
            return x;
        }

        public List<Contract.Schedule> GetCurrentRelease()
        {
            var x = GetCurrentSchedules(DV.Release);
            return x;
        }
    }
}
