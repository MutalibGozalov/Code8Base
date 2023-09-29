using HackathonPrep.Domain.Common;
using HackathonPrep.Domain.Identity;

namespace HackathonPrep.Domain.Entities;
public class Interest : BaseAuditable
{
    public ICollection<string> EnjoyedSubjects { get; set; } //type -> Enum
    public ICollection<string> Hobbies { get; set; } //type -> Enum
    public string CareerEnvision { get; set; } //type -> Enum

    public AppUser User { get; set; }
    public int UserId { get; set; }
}