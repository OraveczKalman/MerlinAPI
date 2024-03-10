using System;
using System.Collections.Generic;

namespace MerlinAPI.Models;

public partial class TaskItem
{
    public long TaskItemId { get; set; }
    public long TaskId { get; set; }
    public string TaskItemDescription { get; set; } = null!;
    public string Comment { get; set; } = null!;
    public long TaskItemUser { get; set; }
    public long TaskItemIdInner { get; set; }
    public string Post { get; set; } = null!;
    public sbyte Completed { get; set; }
    public DateTime Created { get; set; }
    public long CreatedBy { get; set; }
    public DateTime Modified { get; set; }
    public long ModifiedBy { get; set; }
}
