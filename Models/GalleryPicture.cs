using System;
using System.Collections.Generic;

namespace MerlinAPI.Models;

public partial class GalleryPicture
{
    public long LangHeaderId { get; set; }
    public long PictureId { get; set; }
    public long Rank { get; set; }
    public sbyte? Cover { get; set; }
    public sbyte Active { get; set; }
}
