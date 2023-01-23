using RealChat.Domain.Domains.User;

namespace RealChat.Domain.Domains.Groups
{
    public class GroupMessages : Message
    {
        private ApplicationUser _sender;
        public GroupMessages(ApplicationUser sender, string text) : base(text)
        {
            _sender = sender;
        }

        public ApplicationUser Sender => _sender;

    }
}
