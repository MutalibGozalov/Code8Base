namespace HackathonPrep.Application.DTOs;

public class ApplicantDto
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public string Status { get; set; }

    public StudentDto? User { get; set; }
    public string? UserId { get; set; }
}
