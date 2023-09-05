using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelsDB.Layout
{
    public class Navbar : BaseModel
    {
        [Key]
        public int Id { get; set; }
        
        public LayoutCategory LayoutCategory { get; set; }
        public int LayoutCategoryId { get; set; }
        public List<Tab> Tabs { get; set; }
    }
}
