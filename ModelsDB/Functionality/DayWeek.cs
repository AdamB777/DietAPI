namespace ModelsDB.Functionality
{
    public class DayWeek : BaseModel
    {
        public int Id { get; set; }
        public string Day { get; set; }

        public List<SingleDiet> SingleDiets { get; set; }
    }
}