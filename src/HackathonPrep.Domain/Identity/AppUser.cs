using HackathonPrep.Domain.Entities;
using Microsoft.AspNetCore.Identity;

namespace HackathonPrep.Domain.Identity;
public class AppUser : IdentityUser
{
    public string FullName { get; set; } = null!;
    public DateTime BirthDate { get; set; }
    public bool Gender { get; set; }
    public DateTime AppointmentDate { get; set; }
    public string DeviceId { get; set; } = null!;

    public Education Education { get; set; }
    public Interest Interest { get; set; }
    public ICollection<Applicant> Applicants { get; set; }
}