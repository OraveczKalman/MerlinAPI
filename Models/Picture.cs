using System;
using System.Collections.Generic;

namespace MerlinAPI.Models;

public partial class Picture
{
    public long PictureId { get; set; }
    public string? Name { get; set; }
    public string? ThumbName { get; set; }

    /// <summary>
    /// 1: kép, 2: youtube video, 3: feltöltött video, 4: zene, 5: feltöltött file
    /// </summary>
    public sbyte? MediaType { get; set; }
    public string? OriginalExtension { get; set; }
    public DateTime Created { get; set; }
    public long CreatedBy { get; set; }
    public DateTime Modified { get; set; }
    public long ModifiedBy { get; set; }
    public sbyte Active { get; set; }
}
