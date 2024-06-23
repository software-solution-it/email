// Controllers/JobController.cs
using Microsoft.AspNetCore.Mvc;

namespace track_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class JobController : ControllerBase
    {
        private readonly JobService _jobService;

        public JobController(JobService jobService)
        {
            _jobService = jobService;
        }

        [HttpPost("startJob")]
        public IActionResult StartJob()
        {
            _jobService.StartJob();
            return Ok("Job started.");
        }
    }
}
