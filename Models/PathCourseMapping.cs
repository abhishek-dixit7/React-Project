using System;
using System.Collections.Generic;

namespace ReactProject.Models;

public partial class PathCourseMapping
{
    public long Id { get; set; }

    public long PathId { get; set; }

    public long CourseId { get; set; }

    public int Sequence { get; set; }

    public bool IsActive { get; set; }

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime? UpdatedDate { get; set; }

    public string? UpdatedBy { get; set; }
}
