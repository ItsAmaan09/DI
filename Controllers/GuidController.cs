using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/v1/[controller]")]
public class GuidController : ControllerBase
{
    private readonly IGuidServiceSingleton _singleton;
    private readonly IGuidServiceScoped _scoped;
    private readonly IGuidServiceTransient _transient;

    public GuidController(IGuidServiceSingleton singleton, IGuidServiceScoped scoped, IGuidServiceTransient transient)
    {
        _singleton = singleton;
        _scoped = scoped;
        _transient = transient;
    }

    [HttpGet]
    public IActionResult GetGuids()
    {
        return Ok(new
        {
            Singleton = _singleton.GetGuid(),
            Scoped = _scoped.GetGuid(),
            Transient = _transient.GetGuid() 
        });
    }
}