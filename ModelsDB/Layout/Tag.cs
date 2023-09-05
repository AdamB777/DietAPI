using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelsDB.Layout
{
    public class Tag : BaseModel
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
