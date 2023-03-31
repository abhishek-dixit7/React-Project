using System;
using System.Collections.Generic;

namespace ReactProject.Models;

public partial class LearningPath
{
    public long Id { get; set; }

    public string PathName { get; set; } = null!;

    public string PathDescription { get; set; } = null!;

    public string Image { get; set; } = null!;

    public bool IsActive { get; set; }

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime? UpdatedDate { get; set; }

    public string? UpdatedBy { get; set; }
}
