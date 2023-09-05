namespace ModelsDB.Functionality
{
    public class CategoryOfDiet : BaseModel
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }

        public List<SingleDiet> SingleDiets { get; set; }
    }
}