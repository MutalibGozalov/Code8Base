using HackathonPrep.Domain.Entities;

namespace HackathonPrep.Domain.Identity;
public class AppUser : IdentityUser
{
    public string FullName { get; set; } = null!;
    public DateTime BirthDate { get; set; } = null!;
    public bool Gender { get; set; } = null!;
    public DateTime AppointmentDate { get; set; }
    public string DeviceId { get; set; } = null!;

    public Education Education { get; set; }
    public Interest Interest { get; set; }
    public Applicant Applicant { get; set; }
}