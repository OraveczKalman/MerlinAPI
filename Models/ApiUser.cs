using System;
using System.Collections.Generic;

namespace MerlinAPI.Models;

public partial class ApiUser
{
    public long ApiUserId { get; set; }
    public string ApiUserName { get; set; } = null!;
    public string ApiPassword { get; set; } = null!;
    public long ApiDeviceCount { get; set; }
    public DateTime Created { get; set; }
    public long CreatedBy { get; set; }
    public DateTime? Modified { get; set; }
    public long? ModifiedBy { get; set; }
}
