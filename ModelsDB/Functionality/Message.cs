namespace ModelsDB
{
    public class Message : BaseModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public List<Dietician> Dieticians { get; set; }
        public List<Patient> Patients { get; set; }
    }
}