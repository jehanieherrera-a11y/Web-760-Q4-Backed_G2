namespace ProyectoQ4Backend760.Models;

public class Taskitem
{
    public string Id { get; set; } = string.Empty;
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Priority { get; set; } = "media";
    public string UserId { get; set; } = string.Empty;
    public Datetime CreatedAt { get; set; } = DateTime.UtcNow;
}