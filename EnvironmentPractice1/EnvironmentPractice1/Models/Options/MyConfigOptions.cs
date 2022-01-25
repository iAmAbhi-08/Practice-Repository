using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EnvironmentPractice1.Models.Options
{
    public class MyConfigOptions
    {
        public const string MyConfig = "MyConfig";
        public string Title { get; set; }

        public string  Greet { get; set; }
    }
}
