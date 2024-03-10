using System;
using System.Collections.Generic;

namespace MerlinAPI.Models;

public partial class ForumMessage
{
    public long MessageId { get; set; }
    public long MainHeaderId { get; set; }
    public long? ReplyTo { get; set; }
    public string Message { get; set; } = null!;
    public sbyte Active { get; set; }
    public DateTime Created { get; set; }
    public long CreatedBy { get; set; }
    public DateTime Modified { get; set; }
    public long ModifiedBy { get; set; }
}
