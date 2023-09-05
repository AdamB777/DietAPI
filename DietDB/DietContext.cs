using Microsoft.EntityFrameworkCore;
using ModelsDB;
using ModelsDB.Functionality;

namespace DietDB
{
    public class DietContext : DbContext
    {
        public DietContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Example> Examples { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<CategoryOfDiet> CategoryOfDiet { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<DayWeek> DayWeek { get; set; }
        public DbSet<Diet> Diets { get; set; }
        public DbSet<Dietician> Dieticians { get; set; }
        public DbSet<Diploma> Diplomas { get; set; }
        public DbSet<Dish> Dishes { get; set; }
        public DbSet<FoodCatalog> FoodCatalogs { get; set; }
        public DbSet<Ingridient> Ingridients { get; set; }
        public DbSet<MealTime> MealTime { get; set; }
        public DbSet<Measure> Measures { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Note> Notes { get; set; }
        public DbSet<Office> Offices { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<PatientCard> PatientCards { get; set; }
        public DbSet<Rating> Rating { get; set; }
        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<SingleDiet> SingleDiet { get; set; }
        public DbSet<SingleTestEqual> SingleTestEqual { get; set; }
        public DbSet<Status> Status { get; set; }
        public DbSet<Survey> Surveys { get; set; }
        public DbSet<Term> Terms { get; set; }
        public DbSet<TestEqual> TestEquals { get; set; }
        public DbSet<Visit> Visits { get; set; }
    }
}
