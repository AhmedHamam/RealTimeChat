using Base.Domain.CommonModels;
using RealChat.Domain.Domains.User;

namespace RealChat.Domain.Domains.Groups
{
    public class GroupMembers 
    {
        private readonly ApplicationUser _user;
        private readonly DateTime _joinDate;
        private readonly DateTime _leaveDate;
        public GroupMembers(ApplicationUser user)
        {
            _user = user;
        }
        public DateTime JoinDate => _joinDate;
        public DateTime LeaveDate => _leaveDate;
        public ApplicationUser User => _user;
    }
}
