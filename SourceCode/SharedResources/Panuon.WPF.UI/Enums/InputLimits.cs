using System;

namespace Panuon.WPF.UI
{
    [Flags]
    public enum InputLimits
        : int
    {
        None = 0,
        Digit = 1,
        Letters = 2,
        LowerCaseLetters = 4,
        UpperCaseLetters = 8,
        Point = 16,
        MultiplePoints = 32,
        At = 64,
        MultipleAts = 128,
        Space = 256,
        MultipleSpaces = 512,
        Dash = 1024,
        Underline = 2048,
        Comma = 4096,
        MultipleCommas = 8192,
    }
}
