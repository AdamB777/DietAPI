using ModelsDB.Functionality;

namespace ModelsDB
{
    public class PatientCard : BaseModel
    {
        public int Id { get; set; }

        public int PatientId { get; set; }
        public Patient Patient { get; set; }
        public int SexId { get; set; }
        public Sex Sex { get; set; }
        public List<Survey> Surveys { get; set; }
        public List<TestEqual> testEqual { get; set; }
        public int RatingId { get; set; }
        public Rating Rating { get; set; }
    }
}