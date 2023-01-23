using RealChat.Domain.Domains.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealChat.Domain.Domains.Groups
{
    public class GroupMessages : Message
    {
        private Group _group;
        private ApplicationUser _sender;
        private DateTimeOffset _recivedTime;
        private DateTimeOffset _seenTime;

        public GroupMessages(Group group, ApplicationUser sender, string text) : base(text)
        {
            _group = group;
            _sender = sender;
        }

        public Group Group => _group;
        public ApplicationUser Sender => _sender;
        public DateTimeOffset RecivedTime => _recivedTime;
        public DateTimeOffset SeenTime => _seenTime;

        public void SetSeenTime()
        {
            _seenTime = DateTime.UtcNow;
        }

        public void SetRecivedTime()
        {
            _recivedTime = DateTime.UtcNow;
        }
    }
}
