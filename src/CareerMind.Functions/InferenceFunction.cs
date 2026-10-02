using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CareerMind.Functions;

public class InferenceFunction
{
    private readonly ILogger<InferenceFunction> _logger;

    public InferenceFunction(ILogger<InferenceFunction> logger)
    {
        _logger = logger;
    }

    [Function("InferenceFunction")]
    public IActionResult Run([HttpTrigger(AuthorizationLevel.Function, "get", "post")] HttpRequest req)
    {
        _logger.LogInformation("C# HTTP trigger function processed a request.");
        return new OkObjectResult("Welcome to Azure Functions!");
    }
}
