using ModelsDB.Functionality;

namespace ModelsDB
{
    public class Diet : BaseModel
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<SingleDiet> SingleDiets { get; set; }
        public int DieteticianId { get; set; }
        public Dietician Dietician { get; set; }
        public List<Patient> Patients { get; set; }
    }
}