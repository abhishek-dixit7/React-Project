using System;
using System.Collections.Generic;

namespace ReactProject.Models;

public partial class Enrollment
{
    public Guid EnrollmentId { get; set; }

    public Guid StudentId { get; set; }

    public DateTime EnrollmentDate { get; set; }

    public bool CancelledStatus { get; set; }

    public string? CancelledReason { get; set; }
}
