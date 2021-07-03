using Microsoft.AspNetCore.Mvc;
using System.Reflection;

namespace TestSonarCloud.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VersionController : ControllerBase
    {
        [HttpGet]
        public string GetVersion()
            => Assembly
              .GetExecutingAssembly()
              .GetCustomAttribute<AssemblyInformationalVersionAttribute>().InformationalVersion;
    }
}
