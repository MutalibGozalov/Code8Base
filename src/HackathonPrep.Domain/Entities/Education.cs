using HackathonPrep.Domain.Common;
using HackathonPrep.Domain.Identity;

namespace HackathonPrep.Domain.Entities;
public class Education : BaseAuditable
{
    public string UniversityName { get; set; }  = null!;//type -> Enum
    public string Speciality { get; set; }  = null!;//type -> Enum
    public string CurrentGradeLevel { get; set; }  = null!;//type -> Enum
    public double GPA { get; set; }  = null!;

    public AppUser User { get; set; }
    public int UserId { get; set; }
}