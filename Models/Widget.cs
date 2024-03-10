using System;
using System.Collections.Generic;

namespace MerlinAPI.Models;

public partial class Widget
{
    public long WidgetId { get; set; }
    public string? ControllerName { get; set; }
    public DateTime? Created { get; set; }
    public long? CreatedBy { get; set; }
    public DateTime? Modified { get; set; }
    public long? ModifiedBy { get; set; }
    public long Active { get; set; }
}
