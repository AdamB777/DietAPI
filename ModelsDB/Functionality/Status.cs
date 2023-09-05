namespace ModelsDB.Functionality
{
    public class Status : BaseModel
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Visit> Visits { get; set; }
    }
}