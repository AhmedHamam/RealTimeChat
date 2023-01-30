namespace RealChat.Domain.Domains.User
{
    public class UserLogin
    {
        public int Id { get; set; }
        public string LoginProvider { get; set; }
        public string ProviderKey { get; set; }
        public string ProviderDisplayName { get; set; }
        public int UserId { get; set; }
        public virtual ApplicationUser User { get; set; }
    }
}