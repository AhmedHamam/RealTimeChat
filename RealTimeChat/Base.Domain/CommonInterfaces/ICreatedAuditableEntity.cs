namespace Base.Domain.CommonInterfaces
{
    public interface ICreatedAuditableEntity
    {
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public void MarkAsCreated(string createdBy);
    }
}
