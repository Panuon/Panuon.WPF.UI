using System;

namespace Panuon.WPF.UI
{
    [Flags]
    public enum CarouselAnimation
    {
        Fade = 1,
        Slide = 2,
        Scale = 4,
        Flow = 8,
    }
}
