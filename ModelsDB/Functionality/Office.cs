namespace ModelsDB
{
    public class Office : BaseModel
    {
        public int Id { get; set; }

        public List<Address> Addresses { get; set; }
        public List<Dietician> Dietician { get; set; }
    }
}