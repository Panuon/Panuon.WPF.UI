using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace Panuon.UI.Silver.Internal.Utils
{
    internal static class EnumUtils
    {
        #region IsComboKeysPressed
        internal static bool IsComboKeysPressed(ComboKeys comboKeys)
        {
            if (comboKeys.HasFlag(ComboKeys.None))
            {
                return true;
            }

            var isCtrlPressed = Keyboard.IsKeyDown(Key.LeftCtrl) || Keyboard.IsKeyDown(Key.RightCtrl);
            var isShiftPressed = Keyboard.IsKeyDown(Key.LeftShift) || Keyboard.IsKeyDown(Key.RightShift);
            var isAltPressed = Keyboard.IsKeyDown(Key.LeftAlt) || Keyboard.IsKeyDown(Key.RightAlt);

            var isPressed = false;
            if ((comboKeys.HasFlag(ComboKeys.Ctrl))
                && isCtrlPressed)
            {
                isPressed = true;
            }
            if (comboKeys.HasFlag(ComboKeys.Shift)
                && isShiftPressed)
            {
                isPressed = true;
            }
            if (comboKeys.HasFlag(ComboKeys.Alt)
                && isAltPressed)
            {
                isPressed = true;
            }
            if ((comboKeys.HasFlag(ComboKeys.CtrlAndShift))
                && isCtrlPressed
                && isShiftPressed)
            {
                isPressed = true;
            }
            if ((comboKeys.HasFlag(ComboKeys.CtrlAndAlt))
                && isCtrlPressed
                && isAltPressed)
            {
                isPressed = true;
            }
            if ((comboKeys.HasFlag(ComboKeys.CtrlAltAndShift))
                && isCtrlPressed
                && isShiftPressed
                && isAltPressed)
            {
                isPressed = true;
            }
            return isPressed;
        }
        #endregion
    }
}
