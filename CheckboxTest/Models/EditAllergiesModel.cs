using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CheckboxTest.Models
{
    public class EditAllergiesModel
    {
        public int EpisodeId { get; set; }
        public int PatientId { get; set; }
        public bool IsReadOnly { get; set; }
        public bool? HasNoKnownDrugAllergies { get; set; }
    }
}