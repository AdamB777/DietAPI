using ModelsDB.Functionality;

namespace ModelsDB
{
    public class Patient:BaseModel
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

        public Dietician Dietician { get; set; }
        public int DieticianId { get; set; }
        public List<PatientCard> PatientCard { get; set; }
        public List<Diet> Diets { get; set; }
        public List<Comment> Comments { get; set; }
        public List<Rating> Ratings { get; set; }
        public List<Visit> Visits { get; set; }
        public List<Message> Messages { get; set; }
    }
}