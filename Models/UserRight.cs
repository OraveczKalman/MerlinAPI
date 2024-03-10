using System;
using System.Collections.Generic;

namespace MerlinAPI.Models;

public partial class UserRight
{
    public long UserRightId { get; set; }
    public string? Name { get; set; }
    public long CreatedBy { get; set; }
    public DateTime Modified { get; set; }
    public long ModifiedBy { get; set; }
    public sbyte Active { get; set; }
}
