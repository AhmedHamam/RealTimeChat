namespace Base.Domain.CommonInterfaces
{
    public interface IIsActive
    {
        public bool IsActive { get; set; }
        public void MarkAsActive(string activatedBy);
        public void MarkAsNotActive(string deactivatedBy);
    }
}
