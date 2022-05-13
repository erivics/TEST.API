using System;

namespace TEST.API.Entity
{
    //Create  ==== Delete ==== Update === Get  (CRUD)
    public class Student
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateTimeOffset CreateAt { get; set; }
    }
}