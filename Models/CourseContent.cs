using System;
using System.Collections.Generic;

namespace ReactProject.Models;

public partial class CourseContent
{
    public long ContentId { get; set; }

    public long CourseId { get; set; }

    public int? ParentContentId { get; set; }

    public string? ContentName { get; set; }

    public int? TimeToReadMins { get; set; }

    public int Sequence { get; set; }

    public int RewardPoints { get; set; }

    public bool? IsPaid { get; set; }
}
