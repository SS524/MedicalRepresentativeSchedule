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
        IRepScheduleRepository con = new RepScheduleRepository();
        public IEnumerable<RepSchedule> GetByDate(DateTime date)
        {
            IEnumerable<RepSchedule> rep = con.Get().Where(t => t.DateOfMeeting == date);
            return rep;
        }
    }
}
