using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ProPulse.DataModel.Entities;

namespace ProPulse.DataModel;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

    public DbSet<Article>? Articles { get; set; }
    public DbSet<Attachment>? Attachments { get; set; }
}
