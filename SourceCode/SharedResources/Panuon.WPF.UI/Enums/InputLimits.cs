using System;

namespace Panuon.WPF.UI
{
    [Flags]
    public enum InputLimits
        : int
    {
        None = 0,
        Digit = 1,
        LowerCaseLetters = 2,
        UpperCaseLetters = 4,
        Point = 8,
        MultiplePoints = 16,
        At = 32,
        MultipleAts = 64,
        Space = 128,
        MultipleSpaces = 256,
    }
}
