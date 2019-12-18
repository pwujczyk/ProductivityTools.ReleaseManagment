using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductivityTools.ReleaseManagment.App
{
   public static class AutoMapper
    {
        public static void Setup()
        {
            Mapper.Initialize(cfg => cfg.CreateMap<EF.Schedule, Contract.Schedule>());
        }
    }
}
