using Microsoft.AspNetCore.Mvc;
using LifeCycleDemo.Services;
using LifeCycleDemo.Interface;

namespace LifeCycleDemo.Controllers;

[ApiController]
[Route("[controller]")]
public class DemoController : ControllerBase
{
    private readonly ITransient _transient;
    private readonly IScoped _scoped;
    private readonly ISingleton _singleton;
    public readonly DemoService _service;
    
    public DemoController(ITransient transient, IScoped scoped, ISingleton singleton, DemoService service)
    {
        _transient = transient;
        _scoped = scoped;
        _singleton = singleton;
        _service = service;
    }

    [HttpGet]
    public ActionResult<IDictionary<string, string>> Get()
    {
        var serviceHash = _service.GetServiceHashCode();
        var controllerHash = $"Transient: {_transient.GetHashCode()}, Scoped:: {_scoped.GetHashCode()}, Singleton: {_singleton.GetHashCode()}";
        return new Dictionary<string, string> {
            {"(First call) Obj Hash Codes in DemoService", serviceHash},
            {"(Second call) Obj Hash Codes in DemoController", controllerHash}
        };
    }
}