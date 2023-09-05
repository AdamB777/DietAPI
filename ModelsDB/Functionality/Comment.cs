using System.ComponentModel.DataAnnotations;

namespace ModelsDB
{
    public class Comment : BaseModel
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public int PatientId { get; set; }
        public Patient Patient { get; set; }
        public int DieteticianId { get; set; }
        public Dietician Dietician { get; set; }
    }
}