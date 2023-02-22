using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;
using static Panuon.WPF.UI.Internal.Utils.Win32Util;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows;

namespace Panuon.WPF.UI
{
    public class MicaWindowXEffect : WindowXEffect
    {
        #region Fields
        private WindowX _windowX;
        #endregion

        #region Properties

        #endregion

        #region Overrides

        #region Enable
        protected internal override void Enable(WindowX window)
        {
            _windowX = window;
            ResetWindowEffect(true);
        }
        #endregion


        #region OnDisabled
        protected internal override void Disable()
        {
            ResetWindowEffect(false);
        }
        #endregion

        #endregion

        #region Functions
        private void ResetWindowEffect(bool enable)
        {
            if (_windowX == null)
            {
                return;
            }

            try
            {
                var hwndSource = PresentationSource.FromVisual(_windowX) as HwndSource;

                if (enable)
                {
                    var darkThemeEnabled = false;
                    int trueValue = 0x01;
                    int falseValue = 0x00;

                    if (darkThemeEnabled)
                    {
                        DwmSetWindowAttribute(hwndSource.Handle, DwmWindowAttribute.DWMWA_USE_IMMERSIVE_DARK_MODE, ref trueValue, Marshal.SizeOf(typeof(int)));
                    }
                    else
                    {
                        DwmSetWindowAttribute(hwndSource.Handle, DwmWindowAttribute.DWMWA_USE_IMMERSIVE_DARK_MODE, ref falseValue, Marshal.SizeOf(typeof(int)));
                    }

                    DwmSetWindowAttribute(hwndSource.Handle, DwmWindowAttribute.DWMWA_MICA_EFFECT, ref trueValue, Marshal.SizeOf(typeof(int)));
                }
                else
                {

                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Unable to enable mica effects, an error occurred. " + ex);
            }

        }

        #endregion
    }
}
