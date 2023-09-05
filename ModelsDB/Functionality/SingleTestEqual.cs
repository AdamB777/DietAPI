namespace ModelsDB
{
    public class SingleTestEqual : BaseModel
    {
        public int Id { get; set; }
        public float test1 { get; set; }
        public float test2 { get; set; }
        public float test3 { get; set; }

        public int TestEqualId { get; set; }
        public TestEqual TestEqual { get; set; }
    }
}