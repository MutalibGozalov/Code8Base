namespace HackathonPrep.Application.DTOs;

public class StudentDto
{
    public string Id { get; set; }
    public string? FullName { get; set; }
    public DateTime? BirthDate { get; set; }
    public bool? Gender { get; set; }
    public DateTime? AppointmentDate { get; set; }
    public string? DeviceId { get; set; }

    public EducationDto? Education { get; set; }
    public InterestDto? Interest { get; set; }
    public ICollection<ApplicantDto>? ApplicantDtos { get; set; }
}
