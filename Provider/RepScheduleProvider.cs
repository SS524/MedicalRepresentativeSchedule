using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MedicalRepresentativeScheduleMicroservice.Models;
using MedicalRepresentativeScheduleMicroservice.Repository;
namespace MedicalRepresentativeScheduleMicroservice.Provider
{
    public class RepScheduleProvider
    {
        RepScheduleRepository con;
        public RepScheduleProvider(RepScheduleRepository _con)
        {
            con = _con;
        }
        public static List<RepSchedule> lsrep = new List<RepSchedule>();
        /// <summary>
        /// This is the function where we are creating the schedule for medical representative with the doctor.
        /// By giving date it will create schedule for 5 days starting from the start date ,excluding Sunday.
        /// The function will not create any schedule on Sunday.
        /// </summary>
        /// <param name="date"></param>
        public void CreateSchedule(DateTime date)
        {
            try
            {
                IEnumerable<MedicineStock> stock = con.Get();
                int count = 0;
                while (count != 5)
                {
                    if (date.DayOfWeek != DayOfWeek.Sunday)
                    {
                        Doctor doc = RepScheduleRepository.lsdoc[count];
                        IEnumerable<string> medicines = from m in stock where m.TargetAilment == doc.TreatingAilment select m.Name;
                        RepSchedule rp = new RepSchedule();
                        rp.RepName = MedicalRepresentativeRepository.ls[count % 3].Name;
                        rp.Medicine = medicines;
                        rp.Doctor = doc;
                        rp.MeetingSlot = "1 pm to 2 pm";
                        rp.DateOfMeeting = date;
                        count++;
                        lsrep.Add(rp);
                    }
                    date = date.AddDays(1);
                }
            }
            catch(Exception)
            {

            }
        }
        public IEnumerable<RepSchedule> GetByDate(DateTime date)
        {
            CreateSchedule(date);
            //IEnumerable<RepSchedule> rep = con.Get().Where(t => t.DateOfMeeting == date);
            // return rep;
            return lsrep;
        }
    }
}
