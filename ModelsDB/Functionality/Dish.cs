﻿using System.Diagnostics.Metrics;

namespace ModelsDB
{
    public class Dish : BaseModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Micronutrient { get; set; }
        public float Macronutrient { get; set; }
        public float Calories { get; set; }
        public float Glycemic { get; set; }
        public string DishPhotoUrl { get; set; }

        public int FoodCatalogId { get; set; }
        public FoodCatalog FoodCatalog { get; set; }
        public int IngridientId { get; set; }
        public Ingridient Ingridient { get; set; }
        public int MeasureId { get; set; }
        public Measure Measure { get; set; }
        public int RecipesId { get; set; }
        public Recipe Recipes { get; set; }
    }
}