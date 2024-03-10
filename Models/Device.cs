using System;
using System.Collections.Generic;

namespace MerlinAPI.Models;

public partial class Device
{
    public long DeviceId { get; set; }
    public string DeviceName { get; set; } = null!;
    public string DeviceNumber { get; set; } = null!;
    public DateTime DeviceStartDate { get; set; }
    public DateTime? DeviceEndDate { get; set; }
    public DateTime Created { get; set; }
    public string CreatedBy { get; set; } = null!;
    public DateTime? ModifiedBy { get; set; }
    public string? Modified { get; set; }
}
