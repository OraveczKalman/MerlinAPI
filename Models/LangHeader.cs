using System;
using System.Collections.Generic;

namespace MerlinAPI.Models;

public partial class LangHeader
{
    public long LangHeaderId { get; set; }
    public long MainHeaderId { get; set; }
    public long ParentId { get; set; }
    public long? HeaderBackgroundId { get; set; }
    public string? Caption { get; set; }
    public string? Title { get; set; }
    public string? Heading { get; set; }
    public string? Link { get; set; }
    public string? Keywords { get; set; }
    public string? Language { get; set; }
    public long? Rank { get; set; }
    public long? Counter { get; set; }
    public DateTime Created { get; set; }
    public long CreatedBy { get; set; }
    public DateTime? Modified { get; set; }
    public long? ModifiedBy { get; set; }
    public sbyte Active { get; set; }
}
