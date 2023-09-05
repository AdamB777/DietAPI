namespace ModelsDB.Functionality
{
    public class MealTime : BaseModel
    {
        public int Id { get; set; }
        public string DishTime { get; set; }

        public List<SingleDiet> SingleDiets { get; set; }
    }
}