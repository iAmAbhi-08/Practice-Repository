using AutoMapper;
using EnvironmentPractice1.Models;
using EnvironmentPractice1.Models.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EnvironmentPractice1.Profiles
{
    public class ConfigProfile : Profile
    {
        public ConfigProfile()
        {
            CreateMap<MyConfigOptions, MyConfig>();
        }
    }
}
