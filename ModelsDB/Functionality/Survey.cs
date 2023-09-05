namespace ModelsDB
{
    public class Survey : BaseModel
    {
        public int Id { get; set; }
        public float Heigth { get; set; }
        public float Weith { get; set; }
        public DateTime MeasureTime { get; set; }

        public int PatientCardId { get; set; }
        public PatientCard PatientCard { get; set; }
    }
}