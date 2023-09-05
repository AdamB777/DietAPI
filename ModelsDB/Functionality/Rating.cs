namespace ModelsDB
{
    public class Rating : BaseModel
    {
        public int Id { get; set; }
        public int Note { get; set; }

        public List<Dietician> Dieticians { get; set; }
        public List<Patient> Patients { get; set; }
    }
}