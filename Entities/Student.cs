using System;
using System.Collections.Generic;

namespace AssesmentOnEF.Entities;

public partial class Student
{
    public int StudentId { get; set; }

    public string? Sname { get; set; }

    public string? Qualification { get; set; }

    public string? Skill { get; set; }
}
