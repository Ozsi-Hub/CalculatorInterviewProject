using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;

namespace CalculatorInterview.Controllers
{
    [Microsoft.AspNetCore.Components.Route("api/status")]
    [ApiController]
    public class StatusController : ControllerBase
    {

        [HttpGet]
        public string? GetStatus()
        {
            return GetType()?.Assembly?.GetName()?.Version?.ToString();
        }
    }
}
