﻿using System.Data;

namespace WebApplication1.Model
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DataSetDateTime EnrollmentDate { get; set; }
    }
}
