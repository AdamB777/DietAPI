using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelsDB
{
    [Table("Address")]
    public class Address : BaseModel
    {
        [Key]
        public int Id { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string Country { get; set; }
        public string Street { get; set; }
        public string LocalNo { get; set; }

        public List<MyUser> Users { get; set; }
        public int OfficeId { get; set; }
        public Office Office { get; set; }

    }
}