using HackathonPrep.Domain.Common;
using HackathonPrep.Domain.Enums;
using HackathonPrep.Domain.Identity;

namespace HackathonPrep.Domain.Entities;
public class Applicant : BaseAuditable
{
    public string Name { get; set; }  = null!;
    public Status Status { get; set; }  = null!;

    public AppUser User { get; set; }
    public int UserId { get; set; }
}