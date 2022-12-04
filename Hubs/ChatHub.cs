using Microsoft.AspNetCore.SignalR;

namespace Bercea_Anelise_Laborator2_MPA.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }
    }
}
