using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelsDB.ManualPanel
{
    public class CategoryType : BaseModel
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        
        //another test
        //
    }
}
