using ProductivityTools.ReleaseManagment.Contract;
using System;
using System.Collections.Generic;

namespace ProductivityTools.ReleaseManagment.App.InternalContract
{
    public interface IReleases
    {
        DateTime GetDate();

        IList<Schedule> GetReleases();
        IList<Schedule> GetSprints();
        IList<Schedule> GetBugFixes();
        Schedule GetCurrentSprint();
        Schedule GetCurrentBugFix();
        List<Schedule> GetCurrentRelease();
    }
}
