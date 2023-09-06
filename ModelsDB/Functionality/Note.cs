namespace ModelsDB
{
    public class Note : BaseModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool isVisibleToPatient { get; set; }

        public List<Dietician> Dieticians { get; set; }
        public List<Patient> Patient { get; set; }
    }
}