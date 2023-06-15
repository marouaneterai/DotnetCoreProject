namespace DotnetCoreProject.Models
{
    public enum Role
    {
        ADMIN,
        MANAGER,
        MEMBER
    }

    public class User
    {
        public int Id { get; set; }
        public string Fullname { get; set; } = string.Empty;
        public string Username { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public Role Role { get; set; }

        public Project? Project { get; set; } = null;
        public ICollection<Ticket> Tickets { get; set; } = new List<Ticket>();
    }
}
