using System;
using System.Collections.Generic;

namespace ReactProject.Models;

public partial class StudentLearningStatusView
{
    public long CourseId { get; set; }

    public long ContentId { get; set; }

    public int? ParentContentId { get; set; }

    public int? TimeToReadMins { get; set; }

    public int Sequence { get; set; }

    public int RewardPoints { get; set; }

    public bool IsPaid { get; set; }

    public string? TopicName { get; set; }

    public long LanguageId { get; set; }

    public Guid? StudentId { get; set; }

    public DateTime? DateStarted { get; set; }

    public DateTime? DateCompleted { get; set; }
}
