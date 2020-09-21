using MedicalRepresentativeScheduleMicroservice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedicalRepresentativeScheduleMicroservice.Repository
{
    public class RepScheduleRepository : IRepScheduleRepository
    {
        public static List<RepSchedule> ls = new List<RepSchedule>();
        //{
        //    new RepSchedule
        //    {
        //       RepName="R1",
        //       DoctorName="D1",
        //       TreatingAilment="Orthopaedics",
        //       Medicine=new List<string>
        //       {
        //          "Orthoherb", "Cholecalciferol"
        //       },
        //       MeetingSlot="1 pm to 2 pm",
        //       DateOfMeeting=new DateTime(2020,05,24),
        //       DoctorContactNumber=22244469


        //    },
        //    new RepSchedule
        //    {
        //       RepName="R2",
        //       DoctorName="D2",
        //       TreatingAilment="General",
        //       Medicine=new List<string>
        //       {
        //          "Gaviscon", "Dolo-650"
        //       },
        //       MeetingSlot="2 pm to 3 pm",
        //       DateOfMeeting=new DateTime(2020,05,25),
        //       DoctorContactNumber=22244470


        //    }
        //};

        public static List<Doctor> ls1 = new List<Doctor>
        {
            new Doctor
            {
            DoctorName="D1",
            TreatingAilment="Orthopaedics",
            ContactNo=22244469


            },
            new Doctor
            {
              DoctorName="D2",
            TreatingAilment="General",
            ContactNo=22244470


            },
             new Doctor
            {
              DoctorName="D3",
            TreatingAilment="General",
            ContactNo=22244471


            },
               new Doctor
            {
              DoctorName="D4",
            TreatingAilment="Orthopaedics",
            ContactNo=22244472


            },
               new Doctor
            {
              DoctorName="D5",
            TreatingAilment="Gynaecology",
            ContactNo=22244473


            }
        };

        public IEnumerable<RepSchedule> Get()
        {
            return ls.ToList();
        }

       
    }
}
