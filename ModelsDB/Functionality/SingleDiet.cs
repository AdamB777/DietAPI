using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelsDB.Functionality
{
    public class SingleDiet : BaseModel
    {
        [Key]
        public int Id { get; set; }
        public int MealTimeHour { get; set; }
        public int MealTimeMinute { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }

        public int DietId { get; set; }
        public Diet Diet { get; set; }
        public int DayWeekId { get; set; }
        public DayWeek DayWeek { get; set; }
        public int MealTimeId { get; set; }
        public MealTime MealTime { get; set; }
        public int CategoryOfDietId { get; set; }
        public CategoryOfDiet CategoryOfDiet { get; set; }

    }
}
