using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelsDB.Layout
{
    public class Tab : BaseModel
    {
        [Key]
        public int Id { get; set; }

        public List<SubTab> SubTabs { get; set; }
    }
}
