using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using signal_r.Hubs;

namespace signal_r.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChatHubController : ControllerBase
    {
        private readonly IHubContext<ChatHub> _context;

        public ChatHubController(IHubContext<ChatHub> context)
        {
            _context = context;
        }

        [HttpGet(Name = "SendMessage")]
        public async Task<string> SendMessage(string message)
        {
            await _context.Clients.All.SendAsync("SendMessage", message);
            return "Ok";
        }
    }
}
