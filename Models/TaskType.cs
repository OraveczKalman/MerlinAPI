using System;
using System.Collections.Generic;

namespace MerlinAPI.Models;

public partial class TaskType
{
    public long TaskTypeId { get; set; }
    public string TaskType1 { get; set; } = null!;
    public DateTime Created { get; set; }
    public long CreatedBy { get; set; }
    public DateTime Modified { get; set; }
    public long ModifiedBy { get; set; }
    public sbyte Active { get; set; }
}
