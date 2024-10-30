using Microsoft.EntityFrameworkCore;

public class Context:DbContext
{
public DbSet<Slider> slider_tbl { get; set; }



 protected override void OnConfiguring(DbContextOptionsBuilder db)
    {
        db.UseSqlServer("server=.;database=Ghorfe1;trusted_connection=true;MultipleActiveResultSets=True;TrustServerCertificate=True");
    }

}