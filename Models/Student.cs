using System;
using System.Collections.Generic;

namespace ReactProject.Models;

public partial class Student
{
    public Guid StudentId { get; set; }

    public string FirstName { get; set; } = null!;

    public string? MiddleName { get; set; }

    public string LastName { get; set; } = null!;

    public string EmailId { get; set; } = null!;

    public string MobileNumber { get; set; } = null!;

    public string? Gender { get; set; }

    public string? Qualification { get; set; }

    public string? Profession { get; set; }

    public string? ImagePath { get; set; }

    public string Password { get; set; } = null!;

    public string CreatedDate { get; set; } = null!;

    public int DefaultLanguageId { get; set; }
}
