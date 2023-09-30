namespace HackathonPrep.Application.DTOs;

public class InterestDto
{
    public int Id { get; set; }
    public ICollection<string> EnjoyedSubjects { get; set; } //type -> Enum
    public ICollection<string> Hobbies { get; set; } //type -> Enum
    public string CareerEnvision { get; set; } //type -> Enum

    public StudentDto User { get; set; }
    public int UserId { get; set; }
}
