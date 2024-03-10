using System;
using System.Collections.Generic;

namespace MerlinAPI.Models;

public partial class TaskFile
{
    public long TaskFileId { get; set; }
    public long TaskId { get; set; }
    public long FileId { get; set; }
    public string Comment { get; set; } = null!;
    public DateTime Created { get; set; }
    public long CreatedBy { get; set; }
    public DateTime Modified { get; set; }
    public long ModifiedBy { get; set; }
}
