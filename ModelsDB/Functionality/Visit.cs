using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelsDB.Functionality
{
    public class Visit : BaseModel
    {
        public int Id { get; set; }
        public DateTime DateVisit { get; set; }

        public  int TermId { get; set; }
        public Term Term { get; set; }
        public int StatusId { get; set; }
        public Status Status { get; set; }
        public List<Dietician> Dieticians { get; set; }
        public List<Patient> Patients { get; set; }
    }
}
