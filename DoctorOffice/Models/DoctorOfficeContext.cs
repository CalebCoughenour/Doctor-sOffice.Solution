using Microsoft.EntityFrameworkCore;

namespace DoctorOffice.Models
{
  public class DoctorOfficeContext : DbContext
  {
    public DbSet<Doctor> Doctors { get; set; }
    public DbSet<Patient> Patients { get; set; }
    public DbSet<DoctorPatient> DoctorPatient { get; set; }

    public DoctorOfficeContext(DbContextOptionsBuilder optionsBuilder) : base(options) 
    { 
      optionsBuilder.UseLazyLoadingProxies();
    }
  }
}