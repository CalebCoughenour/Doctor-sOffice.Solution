using System.Collections.Generic;

namespace DoctorOffice.Models
{
  public class Patient
  {
    public Patient()
    {
      this.JoinEntities = new HashSet<DoctorPatient>();
    }

    public int PatientId { get; set; }
    public int DoctorId { get; set; }
    public string Name { get; set; }
    public string ApptDate { get; set; }
    public string Birthdate { get; set; }
    public virtual ICollection<DoctorPatient> JoinEntities { get; }
  }
}