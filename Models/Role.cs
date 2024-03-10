using System;
using System.Collections.Generic;

namespace MerlinAPI.Models;

public partial class Role
{
    public long RoleId { get; set; }
    public string RoleName { get; set; } = null!;
    public string ControllerName { get; set; } = null!;
}
