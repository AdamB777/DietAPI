 namespace ModelsDB
{
    public class Address:BaseModel
    {
        public int Id { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string Country { get; set; }
        public string Street { get; set; }
        public string LocalNo { get; set; }

        public User User { get; set; }
        public int UserId { get; set; }
        public int OfficeId { get; set; }
        public Office Office { get; set; }

    }
}