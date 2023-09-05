using ModelsDB.Functionality;

namespace ModelsDB
{
    public class Patient:User
    {
        public User User { get; set; }
        public int UserId { get; set; }


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