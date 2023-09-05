﻿namespace ModelsDB
{
    public class Note : BaseModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool isVisibleToPatient { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }
        public int PatientId { get; set; }
        public Patient Patient { get; set; }
    }
}