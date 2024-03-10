using System;
using System.Collections.Generic;

namespace MerlinAPI.Models;

public partial class User
{
    public long? UserId { get; set; }
    public string? Name { get; set; }
    public string? UserName { get; set; }
    public string? Password { get; set; }
    public string? Email { get; set; }
    public long? RightId { get; set; }
    public DateTime Created { get; set; }
    public long CreatedBy { get; set; }
    public DateTime? Modified { get; set; }
    public long? ModifiedBy { get; set; }
    public sbyte Active { get; set; }
}
