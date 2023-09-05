namespace ModelsDB
{
    public class Measure : BaseModel
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Dish> Dishes { get; set; }
    }
}