﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelsDB.Layout
{
    public class Carousel : BaseModel
    {
        [Key]
        public int Id { get; set; }
        public string Description { get; set; }

        public LayoutCategory LayoutCategory { get; set; }
        public int LayoutCategoryId { get; set; }
        public List<LayoutPhoto> Photos { get; set; }
    }
}
