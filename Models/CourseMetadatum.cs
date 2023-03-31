using System;
using System.Collections.Generic;

namespace ReactProject.Models;

public partial class CourseMetadatum
{
    public long MetadataId { get; set; }

    public long CourseId { get; set; }

    public string MetadataType { get; set; } = null!;

    public string Metadata { get; set; } = null!;

    public bool IsActive { get; set; }

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime? UpdatedDate { get; set; }

    public string? UpdatedBy { get; set; }
}
