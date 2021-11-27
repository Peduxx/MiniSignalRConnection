using Microsoft.AspNetCore.SignalR;

namespace MiniSignalRServer.Hubs
{
    public class ChatHub : Hub
    {
        public async IAsyncEnumerable<DateTime> Streaming(CancellationToken cancellationToken)
        {
            while (true)
            {
                yield return DateTime.Now;
                await Task.Delay(1000, cancellationToken);
            }
        }
    }
}