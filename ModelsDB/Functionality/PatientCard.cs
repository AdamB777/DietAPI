using ModelsDB.Functionality;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelsDB
{
    [Table("PatientCard")]
    public class PatientCard : BaseModel
    {
        [Key]
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