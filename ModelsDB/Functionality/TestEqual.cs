namespace ModelsDB
{
    public class TestEqual : BaseModel
    {
        public int Id { get; set; }
        public DateTime TestDate { get; set; }

        public int PatientId { get; set; }
        public Patient Patient { get; set; }
        public List<SingleTestEqual> SingleTestEqual { get; set; }
    }
}