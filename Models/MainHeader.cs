using System;
using System.Collections.Generic;

namespace MerlinAPI.Models;

public partial class MainHeader
{
    public long MainHeaderId { get; set; }
    /// <summary>
    /// Tabellánál json, Galéria esetén: 0-normál galéria, 1-címlap slider, 2-slider
    /// </summary>
    public string? AdditionalField { get; set; }
    public long? Role { get; set; }
    public sbyte? MainPage { get; set; }
    public long? MainNode { get; set; }
    public sbyte? MoreFlag { get; set; }
    public long? Counter { get; set; }
    public string? Target { get; set; }
    public sbyte? UserIn { get; set; }
    public sbyte Popup { get; set; }
    public sbyte Commentable { get; set; }
    public string? Module { get; set; }
    public DateTime Created { get; set; }
    public long CreatedBy { get; set; }
    public DateTime? Modified { get; set; }
    public long? ModifiedBy { get; set; }
    public sbyte Active { get; set; }
}
