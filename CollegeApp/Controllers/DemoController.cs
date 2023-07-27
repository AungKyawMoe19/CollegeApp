using CollegeApp.MyLogging;
using Microsoft.AspNetCore.Mvc;

namespace CollegeApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DemoController : ControllerBase
    {
        //private readonly IMyLogger _myLogger;
        private readonly ILogger<DemoController> _logger;

        public DemoController(ILogger<DemoController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public ActionResult Index()
        {
            // _myLogger.Log("Index method started");
            _logger.LogTrace("Log Message from Trace Method");
            _logger.LogDebug("Log Message from Debug Method");
            _logger.LogInformation("Log Message from Information Method");
            _logger.LogWarning("Log Message from Warning Method");
            _logger.LogError("Log Message from Error Method");
            _logger.LogCritical("Log Message from Critical Method");

            return Ok();
        }
    }
}
