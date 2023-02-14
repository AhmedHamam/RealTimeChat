using Base.Domain.CommonModels;

namespace RealChat.Domain.Domains
{
    public abstract class Chat : BaseEntity<long>
    {
        List<Message> Messages { get; set; }

    }
}
