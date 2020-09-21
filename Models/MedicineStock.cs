﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedicalRepresentativeScheduleMicroservice.Models
{
    public class MedicineStock
    {
        public string Name { get; set; }
        public string  ChemicalComposition { get; set; }
        public string TargetAilment { get; set; }
        public DateTime DateOfExpiry { get; set; }
        public int NoOfTablets { get; set; }
    }
}