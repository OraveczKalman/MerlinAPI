using System;
using System.Collections.Generic;

namespace MerlinAPI.Models;

public partial class Text
{
    public long TextId { get; set; }

    public long? SuperiorId { get; set; }

    /// <summary>
    /// 1: cikk bevezető, 2: cikk, 3: képaláírás, 4:termékleírás
    /// </summary>
    public long? Type { get; set; }
    public string? Title { get; set; }
    public string? Text1 { get; set; }
    public string? Language { get; set; }
    public DateTime Created { get; set; }
    public long CreatedBy { get; set; }
    public DateTime? Modified { get; set; }
    public long? ModifiedBy { get; set; }
    public sbyte Active { get; set; }
}
