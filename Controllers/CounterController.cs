using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Prometheus;

namespace PrometheusMetrics.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CounterController : ControllerBase
    {

        Counter counter = Metrics.CreateCounter("my_counter", "index page counter");

        [HttpGet]

        public string Get() 
        {
            counter.Inc();
            return "hello";

        }
    
    
    
    
    }
}
