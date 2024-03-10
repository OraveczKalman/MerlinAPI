using System;
using System.Collections.Generic;

namespace MerlinAPI.Models;

public partial class TaskComment
{
    public long TaskCommentId { get; set; }
    public long TaskId { get; set; }
    public string? Comment { get; set; }
    public DateTime Created { get; set; }
    public long CreatedBy { get; set; }
    public DateTime Modified { get; set; }
    public long ModifiedBy { get; set; }
}
