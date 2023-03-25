using Microsoft.AspNetCore.Mvc;
using MongoClientLibrary;
using MongoClientLibrary.Models;

namespace NoSqlDemo.Controllers;

[ApiController]
[Route("api/[controller]")]
public class WorkspaceDataController : ControllerBase
{
    private readonly ILogger<WorkspaceDataController> _logger;
    private readonly IMongoService _mongoService;

    public WorkspaceDataController(ILogger<WorkspaceDataController> logger, IMongoService mongoService)
    {
        _logger = logger;
        _mongoService = mongoService;
    }

    [HttpGet]
    public async Task<IEnumerable<Workspace>> Get()
    {
        _logger.LogInformation("Received request for workspaces...");
        return await _mongoService.GetAsync();
    }

    [HttpPost]
    public async Task<IActionResult> Post(Workspace newWorkspace)
    {
        await _mongoService.CreateAsync(newWorkspace);
        return CreatedAtAction(nameof(Post), new { id = newWorkspace.Id }, newWorkspace);
    }
}
