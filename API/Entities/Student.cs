using System;

namespace API.Entities;

public class Student
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public required string LastName { get; set; }
}
