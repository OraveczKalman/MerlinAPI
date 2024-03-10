using System;
using System.Collections.Generic;

namespace MerlinAPI.Models;

public partial class Language
{
    public long LanguageId { get; set; }
    public string Description { get; set; } = null!;
    public string LanguageSign { get; set; } = null!;
    public long Default { get; set; }
    public DateTime? Created { get; set; }
    public long? CreatedBy { get; set; }
    public DateTime? Modified { get; set; }
    public long? ModifiedBy { get; set; }
    public long Active { get; set; }
}
