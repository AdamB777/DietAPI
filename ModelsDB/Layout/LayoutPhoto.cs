using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelsDB.Layout
{
    public class LayoutPhoto : BaseModel
    {
        [Key]
        public int Id { get; set; }
        public string PhotoURL { get; set; }
        public string Description { get; set; }
    }
}
