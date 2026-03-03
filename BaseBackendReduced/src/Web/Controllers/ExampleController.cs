using Microsoft.AspNetCore.Mvc;

namespace BaseBackendReduced.Web.Controllers;

[Route("[controller]")]
public class ExampleController : Controller
{
    private readonly ILogger<ExampleController> _logger;

    public ExampleController(ILogger<ExampleController> logger)
    {
        _logger = logger;
    }

    [HttpGet("/HelloWorld")]
    [Produces("application/json")]
    [ProducesResponseType(typeof(HelloWorldResponse), StatusCodes.Status200OK)]
    public ActionResult<HelloWorldResponse> HelloWorld()
    {
        return Ok(new HelloWorldResponse { Message = "Hello World!" });
    }

    public sealed class HelloWorldResponse
    {
        public string Message { get; set; } = default!;
    }
}
