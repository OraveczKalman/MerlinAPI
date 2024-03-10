using System;
using System.Collections.Generic;

namespace MerlinAPI.Models;

public partial class Setupdatum
{
    public long SetupId { get; set; }
    public long? PortalId { get; set; }
    public string SetupData { get; set; } = null!;
}
