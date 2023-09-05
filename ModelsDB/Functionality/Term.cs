﻿namespace ModelsDB.Functionality
{
    public class Term : BaseModel
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Visit> Visits { get; set; }
    }
}