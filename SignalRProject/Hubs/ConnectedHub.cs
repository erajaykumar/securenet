using Microsoft.AspNetCore.SignalR;

namespace SignalRProject.Hubs
{
    public class ConnectedHub:Hub
    {
       
        public async Task SendMessage( string message)
        {
            
                await Clients.All.SendAsync("ReceiveMessage", message);
            
        }

    }
}
