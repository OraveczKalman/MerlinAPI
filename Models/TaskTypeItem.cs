using System;
using System.Collections.Generic;

namespace MerlinAPI.Models;

public partial class TaskTypeItem
{
    public long TaskTypeItemId { get; set; }
    public long TaskTypeId { get; set; }
    public long TaskTypeUserId { get; set; }
    public long TaskTypeItemIdInner { get; set; }
    public string TaskTypeItemDescription { get; set; } = null!;
    public string Post { get; set; } = null!;
    public DateTime Created { get; set; }
    public long CreatedBy { get; set; }
    public DateTime Modified { get; set; }
    public long ModifiedBy { get; set; }
    public sbyte Active { get; set; }
}
