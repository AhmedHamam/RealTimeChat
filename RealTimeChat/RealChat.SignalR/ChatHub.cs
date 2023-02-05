
using Microsoft.AspNetCore.SignalR;

namespace RealChat.SignalR
{
    public class ChatHub:Hub
    {
        public void Send(string name, string message)
        {
            Clients.All.SendAsync("send", name, message);
        }

        public void SendToGroup(string groupName, string name, string message)
        {
            Clients.Group(groupName).SendAsync("sendToGroup", name, message);
        }

        public void JoinGroup(string groupName)
        {
            Groups.AddToGroupAsync(Context.ConnectionId, groupName);
        }
        public void LeaveGroup(string groupName)
        {
            Groups.RemoveFromGroupAsync(Context.ConnectionId, groupName);
        }

        public void SendToUser(string userId, string name, string message)
        {
            Clients.User(userId).SendAsync("sendToUser", name, message);
        }
        public void SendToCaller(string name, string message)
        {
            Clients.Caller.SendAsync("sendToCaller", name, message);
        }
        public void SendToOthers(string name, string message)
        {
            Clients.Others.SendAsync("sendToOthers", name, message);
        }
        public void SendToOthersInGroup(string groupName, string name, string message)
        {
            Clients.OthersInGroup(groupName).SendAsync("sendToOthersInGroup", name, message);
        }
        public void SendToConnection(string connectionId, string name, string message)
        {
            Clients.Client(connectionId).SendAsync("sendToConnection", name, message);
        }
        public void SendToAllExcept(string name, string message)
        {
            Clients.AllExcept(Context.ConnectionId).SendAsync("sendToAllExcept", name, message);
        }
        public void SendToGroupExcept(string groupName, string name, string message)
        {
            Clients.GroupExcept(groupName, Context.ConnectionId).SendAsync("sendToGroupExcept", name, message);
        }
        public void onConnected()
        {
            Clients.All.SendAsync("onConnected", Context.ConnectionId);
        }
        public void onDisconnected()
        {
            Clients.All.SendAsync("onDisconnected", Context.ConnectionId);
        }


    }
}