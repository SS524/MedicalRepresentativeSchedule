using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedicalRepresentativeScheduleMicroservice.Models
{
    public class RepSchedule
    {
        public string RepName { get; set; }
        public string DoctorName { get; set; }
      //  public string TreatingAilment { get; set; }
     //   public List<string> Medicine { get; set; }
        public string MeetingSlot { get; set; }
        public DateTime DateOfMeeting { get; set; }
        public long DoctorContactNumber { get; set; }
    }
}
