using Microsoft.AspNetCore.Mvc;
using ZapierWebhook.Models;

namespace ZapierWebhook.Controllers;

[ApiController]
[Route("api/[controller]")]
public class WebhookController : ControllerBase
{
    [HttpPost]
    public IActionResult Post([FromBody] PayloadModel payload)
    {
        Console.WriteLine($"Received Webhook: Name = {payload.Name}, Email = {payload.Email}");
        return Ok(new { status = "received", payload = payload });
    }
}
