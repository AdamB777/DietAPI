using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelsDB.ManualPanel
{
    public class FileCategory : BaseModel
    {
        [Key]
        public int Id { get; set; }
        public string Description { get; set; }

        public CategoryType CategoryType { get; set; }
        public int CategoryTypeId { get; set; }
    }
}
