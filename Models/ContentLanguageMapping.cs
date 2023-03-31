using System;
using System.Collections.Generic;

namespace ReactProject.Models;

public partial class ContentLanguageMapping
{
    public long Id { get; set; }

    public long ContentId { get; set; }

    public long LanguageId { get; set; }

    public string? TopicName { get; set; }

    public string? TopicSummary { get; set; }

    public string? ContentPath { get; set; }
}
