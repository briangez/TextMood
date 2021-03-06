using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;
using TextMood.Backend.Common;
using TextMood.Shared;

namespace TextMood.SignalR
{
    public class TextMoodModelHub : Hub
    {
        [HubMethodName(SignalRConstants.SendNewTextMoodModelMethod)]
        public Task SendNewTextMoodModel(TextMoodModel textMoodModel) => Clients.All.SendAsync(SignalRConstants.SendNewTextMoodModelCommand, textMoodModel);
    }
}