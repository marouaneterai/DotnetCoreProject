namespace DotnetCoreProject.Models
{
    public enum Status
    {
        CREATED,
        ASSIGNED,
        ONGOING,
        INTEGRATED,
        CLOSED
    }

    public class Ticket
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Priority { get; set; } = string.Empty;
        public Status Status { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime ClosedAt { get; set; } = DateTime.UtcNow;

        public Project Project { get; set; } = new Project();
        public User User { get; set; } = new User();
    }
}
