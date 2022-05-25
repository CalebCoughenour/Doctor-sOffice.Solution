using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DoctorOffice.Models
{
  public class Doctor
  {
    public Doctor()
    {
      this.JoinEntities = new HashSet<DoctorPatient>();
    }

    public string Name { get; set; }
    public string Specialty { get; set; }
    public int DoctorId { get; set; }
    public virtual ICollection<DoctorPatient> JoinEntities { get; set; }
  }
}