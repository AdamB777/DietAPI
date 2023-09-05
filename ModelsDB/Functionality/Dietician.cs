using ModelsDB.Functionality;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelsDB
{
    public class Dietician:User
    {
        public int UserId { get; set; }
        public User User { get; set; }
        public int RatingId { get; set; }
        public Rating Rating { get; set; }
        public List<Message> Messages { get; set; }
        public List<Diploma> Diplomas { get; set; }
        public List<Patient> Patients { get; set; }
        public List<FoodCatalog> FoodCatalogs { get; set; }
        public List<Office> Offices { get; set; }
        public List<Visit> Visits { get; set; }
    }
}
