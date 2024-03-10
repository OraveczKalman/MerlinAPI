using System;
using System.Collections.Generic;

namespace MerlinAPI.Models;

public partial class Right
{
    public long RightId { get; set; }
    public string? RightName { get; set; }
    public DateTime? Created { get; set; }
    public long? CreatedBy { get; set; }
    public DateTime? Modified { get; set; }
    public long? ModifiedBy { get; set; }
}
