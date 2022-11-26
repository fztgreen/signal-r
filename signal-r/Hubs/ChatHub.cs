using Microsoft.AspNetCore.SignalR;

namespace signal_r.Hubs
{
    public interface IChatHub
    {
        Task SendMessage(string message);
    }

    public class ChatHub : Hub<IChatHub>
    {
        //public async Task SendMessage(string user, string message)
        //{
        //    await Clients.All.SendMessage(message);
        //}
    }
}
