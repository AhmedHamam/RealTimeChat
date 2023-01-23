using Base.Domain.CommonModels;

namespace RealChat.Domain.Domains.Groups
{
    public class Group : BaseEntity<int>
    {
        //Name
        //Description
        //GroupChat
        //GroupMembers
        //GroupMessages

        private string _name;
        private string _description;
        private GroupChat _groupChat;
        private GroupMembers _groupMembers;
        
    }
}
