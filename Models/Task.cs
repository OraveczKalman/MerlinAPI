using System;
using System.Collections.Generic;

namespace MerlinAPI.Models;

public partial class Task
{
    public long TaskId { get; set; }
    public long TaskTypeId { get; set; }
    public string TaskDescription { get; set; } = null!;
    public sbyte TaskCompleted { get; set; }
    public DateTime TaskCompletedTime { get; set; }
    public DateTime Created { get; set; }
    public long CreatedBy { get; set; }
    public DateTime Modified { get; set; }
    public long ModifiedBy { get; set; }
}
