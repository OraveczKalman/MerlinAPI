using System;
using System.Collections.Generic;

namespace MerlinAPI.Models;

public partial class DeviceUser
{
    public long DeviceUserId { get; set; }
    public long DeviceId { get; set; }
    public long UserId { get; set; }
    public string Password { get; set; } = null!;
    public DateTime Created { get; set; }
    public long CreatedBy { get; set; }
    public DateTime? Modified { get; set; }
    public long? ModifiedBy { get; set; }
}
