using AutoMapper;
using EnvironmentPractice1.Models;
using EnvironmentPractice1.Models.Options;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EnvironmentPractice1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EnvironmentController : Controller
    {
        private readonly MyConfigOptions _options;
        private readonly IMapper _mapper;

        public EnvironmentController(IOptionsSnapshot<MyConfigOptions> options,IMapper mapper)
        {
            _options = options.Value;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var myModel = _mapper.Map<MyConfig>(_options);

            return Ok(myModel);
        }
    }
}
