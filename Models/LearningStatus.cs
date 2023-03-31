using System;
using System.Collections.Generic;

namespace ReactProject.Models;

public partial class LearningStatus
{
    public Guid Id { get; set; }

    public Guid StudentId { get; set; }

    public int CourseId { get; set; }

    public int ContentId { get; set; }

    public int? ParentContentId { get; set; }

    public DateTime DateStarted { get; set; }

    public DateTime? DateCompleted { get; set; }
}
