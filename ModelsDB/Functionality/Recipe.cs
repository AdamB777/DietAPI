namespace ModelsDB
{
    public class Recipe : BaseModel
    {
        public int Id { get; set; }
        public string Step { get; set; }

        public List<Dish> Dishes { get; set; }
    }
}