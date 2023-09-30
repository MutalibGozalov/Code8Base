using HackathonPrep.Application.Common.Interfaces;
using HackathonPrep.Domain.Entities;
using HackathonPrep.Domain.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HackathonPrep.Infrastructure.Persistence;

public class ApplicationDbContext : IdentityDbContext<AppUser, AppRole, string>, IApplicationDbContext
{

    public DbSet<Applicant> Applicants { get; set; }
    public DbSet<Education> Educations { get; set; }
    public DbSet<Interest> Interests { get; set; }

    public ApplicationDbContext(
        DbContextOptions<ApplicationDbContext> options
       ) : base(options)
    {
    }

}
