using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProductivityTools.ReleaseManagment.App.InternalContract;
using ProductivityTools.ReleaseManagment.Contract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ProductivityTools.ReleaseManagment.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GeneralController : ControllerBase
    {
        private readonly IReleases releases;

        public GeneralController(IReleases releases)
        {
            this.releases = releases;
        }

        [HttpGet]
        [Route(MethodNames.GetReleaseInfo)]
        public ActionResult<ReleaseInfo> GetReleaseInfo()
        {
            ReleaseInfo result = new ReleaseInfo();
            var x = releases.GetReleases();
            return result;
        }

        [HttpGet]
        [Route(MethodNames.GetSprints)]
        public IList<Schedule> GetSprints()
        {
            var x = releases.GetSprints();
            return x;
        }

        [HttpGet]
        [Route(MethodNames.GetCurrentSprint)]
        public Schedule GetCurrentSprint()
        {
            var x = releases.GetCurrentSprint();
            return x;
        }

        [HttpGet]
        [Route(MethodNames.GetBugFixes)]
        public IList<Schedule> GetBugFixes()
        {
            var x = releases.GetBugFixes();
            return x;
        }

        [HttpGet]
        [Route(MethodNames.GetCurrentBugFix)]
        public Schedule GetCurrentBugFix()
        {
            var x = releases.GetCurrentBugFix();
            return x;
        }


        [HttpGet]
        [Route(MethodNames.GetReleases)]
        public Schedule GetReleases()
        {
            var x = releases.GetCurrentBugFix();
            return x;
        }

        [HttpGet]
        [Route(MethodNames.GetCurrentRelease)]
        public List<Schedule> GetCurrentRelease()
        {
            var x = releases.GetCurrentRelease();
            return x;
        }

    }
}