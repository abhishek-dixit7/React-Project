using System;
using System.Collections.Generic;

namespace ReactProject.Models;

public partial class Language
{
    public long LanguageId { get; set; }

    public string LanguageName { get; set; } = null!;

    public bool IsActive { get; set; }

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime? UpdatedDate { get; set; }

    public string? UpdatedBy { get; set; }
}
