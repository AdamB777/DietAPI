using ModelsDB.Functionality;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelsDB
{
    public class Dietician:BaseModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public string PhotoUrl { get; set; }
        public bool isPatient { get; set; }
        public bool isDietician { get; set; }
        public bool isAdmin { get; set; }


        public Address Address { get; set; }
        public int AddressId { get; set; }
        public List<Note> Notes { get; set; }
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
