using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Prometheus;

namespace PrometheusMetrics.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class demoController : ControllerBase
    {
        Counter counter = Metrics.CreateCounter("demo_counter", "index page counter");

        [HttpGet]

        public string Get()
        {
            counter.Inc();
            return "hello";

        }
    }
}
