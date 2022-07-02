using CustomVerb.Infrastructure;
using Microsoft.AspNetCore.Mvc;

namespace CustomVerb.Api;

[Route("api/[controller]", Name = nameof(CustomVerbController))]
[ApiController]
public class CustomVerbController : ControllerBase
{

    // GET
    [HttpQuery]
    public ActionResult<string> GetCustomVerbAsync([FromBody] Data data)
    {
        var (name, amount, isSomething, children) = data;

        var msg =
            $"Got data with name {name}, amount {amount}, it {(isSomething ? "is" : "is not")} something, and has {children.Length} children";
        Console.WriteLine(msg);
        return Ok(msg);
    }

    public record Data(string Name, int Amount, bool IsSomething, Data[] Children);
}