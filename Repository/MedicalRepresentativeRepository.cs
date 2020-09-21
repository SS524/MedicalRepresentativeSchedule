using MedicalRepresentativeScheduleMicroservice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedicalRepresentativeScheduleMicroservice.Repository
{
    public class MedicalRepresentativeRepository
    {
        public static List<MedicalRepresentative> ls = new List<MedicalRepresentative>
        {
            new MedicalRepresentative
            {
             Name="Prithwiman",
             Email="prithwi@test.com",
             Password="123er"


            },
            new MedicalRepresentative
            {
             Name="Shubham",
             Email="shubham@test.com",
             Password="xyz55"


            }
        };

    }
}
