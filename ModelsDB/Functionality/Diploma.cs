namespace ModelsDB
{
    public class Diploma : BaseModel
    {
        public int Id { get; set; }
        public string PhotoDiplomaUrl { get; set; }
        public string PhotoDiplomaLink { get; set;}

        public int DieteticianId { get; set; }
        public Dietician Dietician { get; set; }
    }
}