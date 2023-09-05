namespace ModelsDB
{
    public class FoodCatalog : BaseModel
    {
        public int Id { get; set; }
        public string CatalogName { get; set; }
        public List<Dish> Dishes { get; set; }
        public int DieteticianId { get; set; }
        public Dietician Dietician { get; set; }
    }
}